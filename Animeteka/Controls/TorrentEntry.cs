using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nyaaParser;
using MonoTorrent.Client;
using MonoTorrent;
using System.IO;

namespace Animeteka.Controls
{
    public partial class TorrentEntry : UserControl
    {
        ParserEntry entry;
        ClientEngine engine;

        public TorrentEntry()
        {
            InitializeComponent();
        }

        public TorrentEntry(ParserEntry entry)
        {
            InitializeComponent();

            this.entry = entry;

            label1.Text = entry.Title;

            Console.WriteLine(entry.FilePath);
            if (File.Exists(entry.FilePath))
            {
                button1.Enabled = false;
                button1.Text = "Загружено";
            }
            // open file as video feature
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entry.DownloadEntry();
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            button1.Enabled = false;
            button1.Text = "Загрузка";

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Torrent torrent = Torrent.Load(entry.FilePath + ".torrent");

            // Create the manager which will download the torrent to savePath
            // using the default settings.
            TorrentManager manager = new TorrentManager(torrent, entry.downloadsPath, new TorrentSettings());

            engine = new ClientEngine();

            // Register the manager with the engine
            this.engine.Register(manager);

            // Begin the download. It is not necessary to call HashCheck on the manager
            // before starting the download. If a hash check has not been performed, the
            // manager will enter the Hashing state and perform a hash check before it
            // begins downloading.

            // If the torrent is fully downloaded already, calling 'Start' will place
            // the manager in the Seeding state.
            manager.StartAsync();

            while (progressBar1.Value < 100)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = (int)manager.Bitfield.PercentComplete;
                    label2.Text = manager.Bitfield.PercentComplete.ToString() + "%";
                }));

                System.Threading.Thread.Sleep(200);
            }

            BeginInvoke(new MethodInvoker(delegate
            {
                button1.Text = "Загружено";
            }));

            

            manager.StopAsync();
            engine.Dispose();
            manager.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "/select," + entry.FilePath);
        }
    }
}
