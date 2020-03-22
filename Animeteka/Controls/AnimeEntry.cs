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
    public partial class AnimeEntry : UserControl
    {
        public AnimeEntry(Anime anime)
        {
            InitializeComponent();

            title.Text = anime.AnimeName;
            type.Text = anime.Atype.AtypeName;
            studio.Text = anime.Studio.StudioName;
            year.Text = "Год: " + anime.AirDate.Value.Year;
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AnimeEntry_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(">>>>>>>>>drawing a line");
        }

        private void AnimeEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
