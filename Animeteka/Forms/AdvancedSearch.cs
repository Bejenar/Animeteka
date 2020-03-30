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
        IEnumerable<Anime> animeEntries;

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
            //adsControl.Genre.SelectedItem = adsControl.Genre.Items[0];

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
            backgroundEntryWorker.RunWorkerAsync();

            
            //.Select(anime => new { anime.AnimeName, anime.Atype.AtypeName, anime.AnimeAndGenre, anime.AirDate });

            
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
                Console.WriteLine(g.Genre.GenreName); 
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

        private void backgroundEntryWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                bunifuCircleProgressbar1.Visible = true;
                bunifuCircleProgressbar1.Value = 0;

            }));
            string atitle = null;
            AnimeType atype = null;
            Studio astudio = null;
            CheckedListBox.CheckedItemCollection agenres = null;

            
            BeginInvoke(new MethodInvoker(delegate
            {
                atitle = searchBox.Text;
                atype = (AnimeType)adsControl.Type.SelectedItem;
                astudio = (Studio)adsControl.Studio.SelectedItem;
                agenres = adsControl.Genre.CheckedItems;

            }));

            animeEntries = Program.db.Anime
                .Include(a => a.Atype)
                .Include(a => a.Studio)
                .Include(a => a.AnimeAndGenre)
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

            backgroundEntryWorker.ReportProgress(10);

            BeginInvoke(new MethodInvoker(delegate
            {
                panelEntry.Controls.Clear();
            }));
            float progress = 10;
            float step = 90f / animeEntries.Count();
            foreach (var a in animeEntries)
            {
                AnimeEntry entry = new AnimeEntry(a);
                entry.Dock = DockStyle.Top;
                
                BeginInvoke(new MethodInvoker(delegate
               {
                   entry.Visible = false;
                   panelEntry.Controls.Add(entry);
                   entry.BringToFront();  // entry.BringToFront(); - to add controls in correct order
                   entry.Visible = true;                 
               }));
                System.Threading.Thread.Sleep(100);
                
                Console.WriteLine(">>>>>>>>>>>>>>  " + a.AnimeName);
                progress += step;
                backgroundEntryWorker.ReportProgress((int)progress);
            }

            BeginInvoke(new MethodInvoker(delegate
            {
                bunifuCircleProgressbar1.Visible = false;
            }));
        }

        private void backgroundEntryWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>> worker done");
        }

        private void backgroundEntryWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bunifuCircleProgressbar1.Value = e.ProgressPercentage;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
