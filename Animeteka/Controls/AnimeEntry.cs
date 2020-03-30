using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Forms;

namespace Animeteka.Controls
{
    public partial class AnimeEntry : UserControl
    {
        int anime_id;

        public AnimeEntry(Anime anime) // передаю сюда аниме из массива
        {
            InitializeComponent();
            anime_id = anime.AnimeId;

            // и каждая новая созданная такая панелька заполняется разными данными

            title.Text = anime.AnimeName;
            if (anime.Atype != null)
                type.Text = anime.Atype.AtypeName;
            if (anime.Studio != null)
                studio.Text = anime.Studio.StudioName;
            year.Text = "Год: " + anime.AirDate.Value.Year;
            try {
                pictureBox1.Load(anime.AnimeUrl);

            }
            catch
            {

            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AnimeEntry_Paint(object sender, PaintEventArgs e)
        {
            //Console.WriteLine(">>>>>>>>>drawing a line");
        }

        private void AnimeEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {
            var frm = new AnimeInfo(anime_id);
            frm.Location = this.FindForm().Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.FindForm().Show(); };
            frm.Show();
            this.FindForm().Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            title.MaximumSize = new Size(panel2.Width - 20, 0);
        }
    }
}
