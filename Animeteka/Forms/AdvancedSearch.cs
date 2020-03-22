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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();

            // populate anime type filter
            var types = Program.db.AnimeType.ToList();
            foreach (var t in types)
            {
                adsControl.Type.Items.Add(t);
            }
            adsControl.Type.SelectedItem = adsControl.Type.Items[0];

            // populate genre filter
            var genres = Program.db.Genre.ToList();
            foreach (var g in genres)
            {
                adsControl.Genre.Items.Add(g);
            }
            adsControl.Genre.SelectedItem = adsControl.Genre.Items[0];

            // populate studio filter
            var studios = Program.db.Studio.ToList();
            foreach (var s in studios)
            {
                adsControl.Studio.Items.Add(s);
            }
            adsControl.Studio.SelectedItem = adsControl.Studio.Items[0];
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var atitle = searchBox.Text;
            
            var atype = (AnimeType)adsControl.Type.SelectedItem;
            var astudio = (Studio)adsControl.Studio.SelectedItem;

            var agenres = adsControl.Genre.CheckedItems;


            var result = Program.db.Anime
                .Include(a => a.Atype)
                .Include(a => a.Studio)
                .Where(a =>
                    ((atitle == "") ? true : a.AnimeName.Contains(atitle))
                && (adsControl.Type_check.Checked ? a.AtypeId == atype.AtypeId : true)
                && (adsControl.Studio_check.Checked ? a.StudioId == astudio.StudioId : true)
                && ((adsControl.Date_check.Checked) ? (a.AirDate.Value > adsControl.DateFrom.Value && a.AirDate.Value < adsControl.DateTo.Value) : true)
                && (adsControl.Status_check.Checked ? (adsControl.Status_release.Checked ? (a.ReleaseDate != null) :
                                              adsControl.Status_airing.Checked ? (a.ReleaseDate == null && a.AirDate < DateTime.Now) :
                                              true) : true)
                )
                .AsEnumerable()
                .Where(a => adsControl.Genre_check.Checked ? CheckGenre(a, agenres) : true);
                //.Select(anime => new { anime.AnimeName, anime.Atype.AtypeName, anime.AnimeAndGenre, anime.AirDate });

            int i = 1;
            panelEntry.Controls.Clear();
            foreach(var a in result)
            {
                AnimeEntry entry = new AnimeEntry(a);
                entry.Dock = DockStyle.Bottom;
                panelEntry.Controls.Add(entry);
                entry.Dock = DockStyle.Top;
                Console.WriteLine(">>>>>>>>>>>>>>  "+a.AnimeName);

            }
            /*Search.Text = "";
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
            }*/
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

        private void animeEntry2_Load(object sender, EventArgs e)
        {
            //animeEntry2.title.Text = "В тот раз я переродился как слизень жопы и украл героя щита из под подмышки";
        }
    }
}
