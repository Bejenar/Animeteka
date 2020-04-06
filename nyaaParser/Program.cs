using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Net;
using System.Web;

using MonoTorrent;
using MonoTorrent.BEncoding;
using MonoTorrent.Client;
using MonoTorrent.Dht;
using System.Threading;

namespace nyaaParser
{
    class Program
    {
        static string dhtNodeFile;
        static string basePath;
        static string downloadsPath = @"C:\Users\jion9\source\repos\Animeteka\nyaaParser\bin\Debug\";
        static string fastResumeFile;
        static string torrentsPath = @"C:\Users\jion9\source\repos\Animeteka\nyaaParser\bin\Debug\";
        static ClientEngine engine;				// The engine used for downloading
        static List<TorrentManager> torrents;	// The list where all the torrentManagers will be stored that the engine gives us


        static string torrentFilePath = "";

        static void Main(string[] args)
        {
            string finalUri = GetQueryUri();

            Console.WriteLine(finalUri);

            string s = getHtml(finalUri);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(s);

            var result = doc.DocumentNode.SelectNodes("//table//tbody//tr[@class='success']//td[@colspan='2']");

            Console.WriteLine(result.Count);

            var k = 1;
            foreach(var r in result)
            {
                string baseUrl = "https://nyaa.si";
                int i = 3;
                //Console.WriteLine("childs: " + r.ChildNodes.Count);
                if(r.ChildNodes.Count == 3)
                {
                    i = 1;
                }
                string path = r.ChildNodes[i].Attributes["href"].Value;
                string fileName = r.ChildNodes[i].InnerText;
                path = path.Replace("view", "download");
                Console.WriteLine(baseUrl + path);

                using (var client = new WebClient())
                {
                    torrentFilePath = Directory.GetCurrentDirectory() + "/" + fileName + ".torrent";
                    client.DownloadFile(baseUrl + path + ".torrent", torrentFilePath);
                    setupClient();
                }
                k++;
            }

           

            Console.ReadLine();
        }

        static void setupClient()
        {
            basePath = Environment.CurrentDirectory;						
            fastResumeFile = Path.Combine(torrentsPath, "fastresume.data");
            dhtNodeFile = Path.Combine(basePath, "DhtNodes");
            torrents = new List<TorrentManager>();						

            // We need to cleanup correctly when the user closes the window by using ctrl-c
            // or an unhandled exception happens
            Console.CancelKeyPress += delegate { Shutdown().Wait(); };
            AppDomain.CurrentDomain.ProcessExit += delegate { Shutdown().Wait(); };
            AppDomain.CurrentDomain.UnhandledException += delegate (object sender, UnhandledExceptionEventArgs e) { Console.WriteLine(e.ExceptionObject); Shutdown().Wait(); };
            Thread.GetDomain().UnhandledException += delegate (object sender, UnhandledExceptionEventArgs e) { Console.WriteLine(e.ExceptionObject); Shutdown().Wait(); };

            StartEngine().Wait();
        }


        private static async Task StartEngine()
        {
            int port = 7878;
            Torrent torrent = null;

            EngineSettings engineSettings = new EngineSettings
            {
                SavePath = downloadsPath,
                ListenPort = port
            };

            TorrentSettings torrentDefaults = new TorrentSettings();

            engine = new ClientEngine(engineSettings);

            byte[] nodes = Array.Empty<byte>();
            try
            {
                if (File.Exists(dhtNodeFile))
                    nodes = File.ReadAllBytes(dhtNodeFile);
            }
            catch
            {
                Console.WriteLine("No existing dht nodes could be loaded");
            }

            DhtEngine dht = new DhtEngine(new IPEndPoint(IPAddress.Any, port));
            await engine.RegisterDhtAsync(dht);

            await engine.DhtEngine.StartAsync(nodes);

            // If the SavePath does not exist, we want to create it.
            if (!Directory.Exists(engine.Settings.SavePath))
                Directory.CreateDirectory(engine.Settings.SavePath);

            // If the torrentsPath does not exist, we want to create it
            if (!Directory.Exists(torrentsPath))
                Directory.CreateDirectory(torrentsPath);

            BEncodedDictionary fastResume = new BEncodedDictionary();
            try
            {
                if (File.Exists(fastResumeFile))
                    fastResume = BEncodedValue.Decode<BEncodedDictionary>(File.ReadAllBytes(fastResumeFile));
            }
            catch
            {
            }


            try
            {
                torrent = await Torrent.LoadAsync(torrentFilePath);
                Console.WriteLine(torrent.InfoHash.ToString());
            }
            catch (Exception e)
            {
                Console.Write("Couldn't decode {0}: ", torrentFilePath);
                Console.WriteLine(e.Message);
            }

            TorrentManager manager = new TorrentManager(torrent, downloadsPath, torrentDefaults);
            if (fastResume.ContainsKey(torrent.InfoHash.ToHex()))
                manager.LoadFastResume(new FastResume((BEncodedDictionary)fastResume[torrent.InfoHash.ToHex()]));
            await engine.Register(manager);

            torrents.Add(manager);


            if (torrents.Count == 0)
            {
                Console.WriteLine("No torrents found in the Torrents directory");
                Console.WriteLine("Exiting...");
                engine.Dispose();
                return;
            }

            foreach (TorrentManager t in torrents)
            {
                await t.StartAsync();
            }

            int i = 0;
            bool running = true;
            StringBuilder sb = new StringBuilder(1024);
            while (running)
            {
                if ((i++) % 10 == 0)
                {
                    sb.Remove(0, sb.Length);
                    running = torrents.Exists(m => m.State != TorrentState.Stopped);

                    foreach (TorrentManager t in torrents)
                    {
                        if (manager.Torrent != null)
                            foreach (TorrentFile file in manager.Torrent.Files)
                                AppendFormat(sb, "{1:0.00}% - {0}", file.Path, file.BitField.PercentComplete);
                    }
                    Console.WriteLine(sb.ToString());
                }

                Thread.Sleep(500);
            }
        }

        private static void AppendFormat(StringBuilder sb, string str, params object[] formatting)
        {
            if (formatting != null)
                sb.AppendFormat(str, formatting);
            else
                sb.Append(str);
            sb.AppendLine();
        }

        private static async Task Shutdown()
        {
            BEncodedDictionary fastResume = new BEncodedDictionary();
            for (int i = 0; i < torrents.Count; i++)
            {
                var stoppingTask = torrents[i].StopAsync();
                while (torrents[i].State != TorrentState.Stopped)
                {
                    Console.WriteLine("{0} is {1}", torrents[i].Torrent.Name, torrents[i].State);
                    Thread.Sleep(250);
                }
                await stoppingTask;

                if (torrents[i].HashChecked)
                    fastResume.Add(torrents[i].Torrent.InfoHash.ToHex(), torrents[i].SaveFastResume().Encode());
            }

            var nodes = await engine.DhtEngine.SaveNodesAsync();
            File.WriteAllBytes(dhtNodeFile, nodes);
            File.WriteAllBytes(fastResumeFile, fastResume.Encode());
            engine.Dispose();

            Thread.Sleep(2000);
        }


        static string GetQueryUri()
        {
            string baseUrl = "https://nyaa.si/";
            string searchString = "[HorribleSubs] Isekai Quartet S2 - 02 [720p].mkv";
            var uriBuilder = new UriBuilder(baseUrl);
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            parameters["q"] = searchString;
            uriBuilder.Query = parameters.ToString();

            return uriBuilder.Uri.AbsoluteUri;
        }

        public static string getHtml(string website)
        {
            Console.WriteLine("target html: " + website);
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                client.Encoding = Encoding.UTF8;
                // Or you can get the file content without saving it
                return client.DownloadString(website);

            }
        }
    }
}
