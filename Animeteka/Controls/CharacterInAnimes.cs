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
    public partial class CharacterInAnimes : UserControl
    {
        public CharacterInAnimes()
        {
            InitializeComponent();
        }

        public CharacterInAnimes(IGrouping<int?, CharacterAnime> characterAnimes)
        {
            InitializeComponent();

            var character = new CharacterPreview(characterAnimes.First().Character);
            character.Dock = DockStyle.Left;
            this.Controls.Add(character);

            var animes = characterAnimes.Take(4);
            foreach(var a in animes)
            {
                var anime = new AnimePreview(a.Anime);
                flowLayoutPanel1.Controls.Add(anime);
            }
        }

        private void animePreview3_Load(object sender, EventArgs e)
        {

        }
    }
}
