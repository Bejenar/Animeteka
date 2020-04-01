using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeteka.Controls
{
    public partial class AnimePreview : UserControl
    {
        private Anime anime;

        public AnimePreview()
        {
            InitializeComponent();
        }

        public AnimePreview(Anime anime)
        {
            InitializeComponent();
            this.anime = anime;

            pictureBox1.LoadAsync(anime.AnimeUrl);
            title.Text = anime.AnimeName;

            toolTip1.SetToolTip(title, anime.AnimeName);
        }
    }
}
