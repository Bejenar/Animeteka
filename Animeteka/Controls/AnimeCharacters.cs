using System;
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
            Panel panel = null;

            characters = Program.db.CharacterAnime
                            .Include(ch => ch.Character)
                            .Where(ch => ch.AnimeId == animeId)
                            .ToList();
            HashSet<int> ids = new HashSet<int>();

            foreach(var ch in characters)
            {
                if (!ids.Contains((int)ch.CharacterId))
                {
                    ids.Add((int)ch.CharacterId);
                    Console.WriteLine(ch.Character.CharacterName + " -  id - " + ch.CharacterId);
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
                    i++;

                }
            }
        }

        private void characterPreview5_Load(object sender, EventArgs e)
        {

        }
    }
}
