﻿using System;
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
        }

        public AnimeInfo(int anime_id)
        {
            InitializeComponent();

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
        }
    }
}
