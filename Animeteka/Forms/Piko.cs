using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Animeteka.Forms
{
    public partial class Piko : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public string fileName = @"D:\torrent\Boku_no_piko.mp4";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Piko()
        {
            InitializeComponent();
            player.settings.mute = true;

            wplayer.URL = @"D:\torrent\piko.mp3";
            wplayer.controls.play();
            /*panel1.Width = 700;
            panel1.Height = 390;
            */
            //vdo.Play();
        }
    }
}
