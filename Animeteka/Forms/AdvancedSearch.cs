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
        int pages = 0;
        int pageIndex = 0;
        int entriesPerPage = 40;

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
            AsyncWorker.RunWorkerAsync();
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

        private IEnumerable<Anime> GetAnimes()
        {
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

            var animes = Program.db.Anime
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
                .OrderByDescending(a => a.AirDate)
                .AsEnumerable()
                .Where(a => adsControl.Genre_check.Checked ? CheckGenre(a, agenres) : true);

            return animes;
        }

        private void backgroundEntryWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                progressBar.Visible = true;
                progressBar.Value = 5;
                pageIndex = 0;
                button_search.Enabled = false;
            }));

            animeEntries = GetAnimes();
            pages = (int)Math.Ceiling(animeEntries.Count() * 1.0 / entriesPerPage);
            AsyncWorker.ReportProgress(10);

            LoadPage.RunWorkerAsync();
        }


        private void LoadPage_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                label1.Text = (pageIndex + 1) + "/" + pages;
                panelPage.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button_search.Enabled = false;
            }));

            var animes = animeEntries.Skip(pageIndex * entriesPerPage).Take(entriesPerPage);
            LoadPage.ReportProgress(10);

            BeginInvoke(new MethodInvoker(delegate
            {
                panelEntry.Controls.Clear();
            }));

            float progress = 10;
            float step = 90f / animes.Count();
            foreach (var a in animes)
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

                progress += step;
                LoadPage.ReportProgress((int)progress);
            }

            BeginInvoke(new MethodInvoker(delegate
            {
                progressBar.Visible = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button_search.Enabled = true;
            }));
        }





























        private void backgroundEntryWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>> worker done");
        }

        private void backgroundEntryWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                progressBar.Value = e.ProgressPercentage;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageIndex < pages - 1)
            {
                pageIndex++;
                label1.Text = (pageIndex + 1) + "/" + pages; 
                LoadPage.RunWorkerAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                pageIndex--;
                label1.Text = (pageIndex + 1) + "/" + pages;
                LoadPage.RunWorkerAsync();
            }
        }
    }
}
