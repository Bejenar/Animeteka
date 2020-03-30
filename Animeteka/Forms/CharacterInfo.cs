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
using Microsoft.EntityFrameworkCore;

namespace Animeteka.Forms
{
    public partial class CharacterInfo : Form
    {
        Characters character = null;
        ICollection<Person> seyus = null;
        ICollection<Anime> animes = null;

        public CharacterInfo()
        {
            InitializeComponent();
        }

        public CharacterInfo(Characters character)
        {
            InitializeComponent();
            this.character = character;

            CharacterPreview preview = new CharacterPreview(character);
            preview.Dock = DockStyle.Left;
            panel1.Controls.Add(preview);

            seyus = Program.db.CharacterAnime
                        .Where(a => a.CharacterId == character.CharacterId)
                        .Select(a => a.Person)
                        .ToList();

            seyus = seyus.Distinct().ToList();

            foreach (var seyu in seyus)
            {
                var person = new PersonPreview(seyu);
                panel2.Controls.Add(person);
                person.Dock = DockStyle.Top;
                person.BringToFront();
            }

            animes = Program.db.CharacterAnime
                        .Where(a => a.CharacterId == character.CharacterId)
                        .Select(a => a.Anime)
                        .ToList();
            animes = animes.Distinct().ToList();

            foreach (var anime in animes)
            {
                var a = new AnimeEntry(anime);
                a.Dock = DockStyle.Top;
                panel3.Controls.Add(a);
                a.BringToFront();
            }


        }
    }
}
