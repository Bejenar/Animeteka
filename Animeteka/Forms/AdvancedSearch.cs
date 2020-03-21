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

            var agenres = Genre.CheckedItems;


            var result = Program.db.Anime
                .Include(a => a.AnimeAndGenre)
                .Where(a =>  
                    ((atype == null) ? true : a.AtypeId == atype.AtypeId)
                &&  ((atitle == "") ? true : a.AnimeName.Contains(atitle))
                &&  ((astudio == null) ? true : a.StudioId == astudio.StudioId)
                &&  ((Date_check.Checked) ? (a.AirDate.Value > DateFrom.Value && a.AirDate.Value < DateTo.Value) : true)
                &&  ( Status_check.Checked ? (Status_release.Checked ? (a.ReleaseDate != null) : 
                                              Status_airing.Checked ? (a.ReleaseDate == null && a.AirDate < DateTime.Now) : 
                                              true) : true)
                )
                .AsEnumerable()
                .Where(a => CheckGenre(a, agenres))
                .Select(anime => new { anime.AnimeName, anime.Atype.AtypeName, anime.AnimeAndGenre, anime.AirDate });

            int i = 1;
            foreach (var a in result)
            {
                Console.WriteLine(">>>>>>>>>> " + a.AirDate.Value + " === " + a.AirDate);
                Search.Text += i++ + ". " + a.AnimeName + " [" + a.AtypeName + "]" + " [" + a.AirDate.Value + "]\r\n";
                string gbuf = "(";
                foreach(var g in a.AnimeAndGenre)
                {
                    gbuf += g.Genre.GenreName + "; ";
                }
                Search.Text += gbuf + ")\r\n\r\n";
            }
        }

        private bool CheckGenre(Anime a, CheckedListBox.CheckedItemCollection genres)
        {
            if (genres == null)
            {
                return true;
            }

            // since HashSet.Contains is O(1) time complexity 
            HashSet<int> agenres = new HashSet<int>();
            foreach (var g in a.AnimeAndGenre)
            {
                agenres.Add((int)g.GenreId);
            }


            foreach(var g in genres)
            {
                var id = ((Genre)g).GenreId;
                // if a title doesn't have one of the checked genres - fuck this title 
                if (!agenres.Contains(id))
                {
                    return false;
                }
            }

            // else add this title to result
            return true;
        }
    }
}
