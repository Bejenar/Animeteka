using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Controls;

using MonoTorrent;
using MonoTorrent.BEncoding;
using MonoTorrent.Client;
using MonoTorrent.Dht;

using nyaaParser;

namespace Animeteka.Forms
{
    public partial class DownloadTorrent : Form
    {
        IHTMLParser nyaaParser;
        List<ParserEntry> entries;
        Anime anime;

        public DownloadTorrent(Anime anime = null)
        {
            InitializeComponent();

            this.anime = anime;

            comboBox1.Items.Add(new NyaaParser());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            textBox1.Text = anime?.AnimeNameEn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entries = nyaaParser.GetParserEntries(textBox1.Text);

 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nyaaParser = (IHTMLParser)comboBox1.SelectedItem;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchString = "[HorribleSubs] " + textBox1.Text + " [" + comboBox2.SelectedItem + "p]";
            Console.WriteLine(searchString);
            entries = nyaaParser.GetParserEntries(searchString);

            foreach(var entry in entries)
            {
                flowLayoutPanel1.Controls.Add(new TorrentEntry(entry));
            }
        }
    }
}
