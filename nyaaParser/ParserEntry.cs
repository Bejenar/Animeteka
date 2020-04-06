using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MonoTorrent;
using MonoTorrent.BEncoding;
using MonoTorrent.Client;
using MonoTorrent.Dht;
namespace nyaaParser
{
    public class ParserEntry
    {
        public string downloadsPath = Directory.GetCurrentDirectory() + @"\Torrents";

        public string FilePath {
            get
            {
                return Directory.GetCurrentDirectory() + @"\Torrents\" + Title;
            }
        }


        public string DownloadString { get;}
        public string Title { get;}

        public ParserEntry(string downloadString, string title)
        {
            DownloadString = downloadString;
            Title = title;
        }

        public void DownloadEntry()
        {
            if (!Directory.Exists(downloadsPath))
            {
                Directory.CreateDirectory(downloadsPath);
            }

            using (var client = new WebClient())
            {
                var torrentFilePath =  FilePath + ".torrent";
                client.DownloadFile(DownloadString, torrentFilePath);
            }
        }



    }
}
