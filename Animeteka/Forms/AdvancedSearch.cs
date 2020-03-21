using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeteka.Forms
{
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();

            // populate anime type filter
            var types = Program.db.AnimeType.ToList();
            foreach(var t in types)
            {
                Type.Items.Add(t);
            }

            // populate genre filter
            var genres = Program.db.Genre.ToList();
            foreach(var g in genres)
            {
                Genre.Items.Add(g);
            }

            // populate studio filter
            var studios = Program.db.Studio.ToList();
            foreach(var s in studios)
            {
                Studio.Items.Add(s);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var atitle = searchBox.Text;
            var atype = (AnimeType)Type.SelectedItem;
            var astudio = (Studio)Studio.SelectedItem;

            var agenres = Genre.SelectedItems;


            var result = Program.db.Anime
                .Where(a =>  
                   ((atype == null) ? true : a.AtypeId == atype.AtypeId)
                && ((atitle == "") ? true : a.AnimeName.Contains(atitle))
                && ((astudio == null) ? true : a.StudioId == astudio.StudioId)
                )
                .Select(anime => new { anime.AnimeName, anime.Atype.AtypeName })
                .ToList();

            int i = 1;
            foreach (var a in result)
            {
                Search.Text += i++ + ". " + a.AnimeName + " [" + a.AtypeName + "]\r\n";
            }
        }

        /*private bool CheckGenre(Anime a, ListBox.SelectedObjectCollection genres)
        {
            if (genres is null) return true;


            HashSet<int> agenres = new HashSet<int>();
            foreach (var g in a.AnimeAndGenre)
            {
                agenres.Add((int)g.GenreId);
            }

            foreach(var g in genres)
            {
                var id = ((Genre)g).GenreId;
                if (!agenres.Contains(id))
                {
                    return false;
                }
            }
            return true;
        }*/
    }
}
