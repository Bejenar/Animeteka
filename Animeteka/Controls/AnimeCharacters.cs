﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace Animeteka.Controls
{
    public partial class AnimeCharacters : UserControl
    {
        private ICollection<CharacterAnime> characters;

        public AnimeCharacters()
        {
            InitializeComponent();
        }

        public AnimeCharacters(int animeId)
        {
            InitializeComponent();

            int i = 1;
            int j = 1;
            Panel panel = null;
            Panel mpanel = null;

            characters = Program.db.CharacterAnime
                            .Include(ch => ch.Character)
                            .Where(ch => ch.AnimeId == animeId)
                            .ToList();
            HashSet<int> ids = new HashSet<int>();

            foreach(var ch in characters)
            {
                if (ch.IsMain == null)
                    continue;

                if ((bool)ch.IsMain)
                {
                    if (!ids.Contains((int)ch.CharacterId))
                    {
                        ids.Add((int)ch.CharacterId);
                        /*Console.WriteLine(ch.Character.CharacterName + " -  id - " + ch.CharacterId);
                        if (j % 5 == 1)
                        {
                            mpanel = new Panel();
                            panel6.Controls.Add(mpanel);
                            mpanel.Dock = DockStyle.Top;
                            mpanel.MinimumSize = new Size(100, 266);
                            mpanel.BringToFront();
                        }

                        var character = new CharacterPreview(ch.Character);
                        mpanel.Controls.Add(character);
                        character.Dock = DockStyle.Left;
                        j++;*/
                        var character = new CharacterPreview(ch.Character);
                        flowLayoutPanel1.Controls.Add(character);

                    }
                }
                else
                {
                    if (!ids.Contains((int)ch.CharacterId))
                    {
                        ids.Add((int)ch.CharacterId);
                        /*Console.WriteLine(ch.Character.CharacterName + " -  id - " + ch.CharacterId);
                        if (i % 5 == 1)
                        {
                            panel = new Panel();
                            panel3.Controls.Add(panel);
                            panel.Dock = DockStyle.Top;
                            panel.MinimumSize = new Size(100, 266);
                            panel.BringToFront();
                        }

                        var character = new CharacterPreview(ch.Character);
                        panel.Controls.Add(character);
                        character.Dock = DockStyle.Left;
                        i++;*/
                        var character = new CharacterPreview(ch.Character);
                        flowLayoutPanel2.Controls.Add(character);

                    }
                }
                
            }
        }

        private void characterPreview5_Load(object sender, EventArgs e)
        {

        }
    }
}
