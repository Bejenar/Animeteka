using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Animeteka.Controls;

namespace Animeteka.Forms
{
    public partial class AnimeInfo : Form
    {
        Anime anime;
        public AnimeInfo()
        {
            InitializeComponent();

            if (Program.is_admin)
            {
                Console.WriteLine("you are admin");
                button1.Visible = true;
            }
        }

        public AnimeInfo(int anime_id)
        {
            InitializeComponent();

            if (Program.is_admin)
            {
                Console.WriteLine("you are admin");
                button1.Visible = true;
            }

            anime = Program.db.Anime
                .Include(a => a.AnimeAndGenre)
                .Include(a => a.Atype)
                .Include(a => a.CharacterAnime)
                .Include(a => a.Personal)
                .Include(a => a.Studio)
                 .Where(a => a.AnimeId == anime_id)
                 .First();


            // anime info panel
            title.Text = anime.AnimeName;
            typeLabel.Text += anime.Atype.AtypeName;
            episodesLabel.Text += anime.EpCount;
            durationLabel.Text += anime.EpDuration + " мин.";
            statusLabel.Text += " Вышло";
            string str = "";
            foreach(var genre in anime.AnimeAndGenre)
            {
                str += genre.Genre.GenreName + ", ";
            }
            genresLabel.Text += str.TrimEnd(new char[] { ' ', ','});
            if (anime.Studio != null)
            studioLabel.Text += anime.Studio.StudioName;

            pictureBox1.LoadAsync(anime.AnimeUrl);


            // characters info panel
            panelCharacters.Controls.Add(new AnimeCharacters(anime.AnimeId));


            // cast info panel
            panelCast.Controls.Add(new AnimeCast(anime.AnimeId));


            //
            panel3.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void OpenEditForm()
        {
            var frm = new AnimeEdit(anime);
            //frm.Location = this.Location;
            //frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new DownloadTorrent(anime);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void AnimeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                Console.WriteLine("key pressed");
            }
        }
    }
}
