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
    public partial class WelcomePage : Form
    {
        bool enteredAnime = false;
        bool enteredCompany = false;
        bool enteredCharacter = false;
        bool enteredPerson = false;

        public WelcomePage()
        {
            // TODO: temporary fix of first query slowness issue 
            //var cache = Program.db.Characters.ToList();

            InitializeComponent();
        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
    System.Globalization.CultureInfo.GetCultureInfo("en");
            this.WindowState = FormWindowState.Normal;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
    System.Globalization.CultureInfo.GetCultureInfo("ru");
            this.WindowState = FormWindowState.Normal;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void button_advanced_Click(object sender, EventArgs e)
        {
            var frm = new AdvancedSearch();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {        
            if(!enteredAnime)
            ShowAnimePanel(panelButtonAnime);

            enteredAnime = true;
        }

        private void ShowAnimePanel(Panel panel)
        {
            panel.Visible = false;
            panel.Width = 550;
            bunifuTransition1.ShowSync(panel);
            panel.Visible = true;
        }

        private void HidePanel(Panel panel)
        {
            panel.Visible = false;
            panel.Width = 10;
            bunifuTransition2.ShowSync(panel);

        }

        private void WelcomePage_MouseEnter(object sender, EventArgs e)
        {
            if (enteredAnime)
            {
                HidePanel(panelButtonAnime);
                enteredAnime = false;
            }

            if(enteredCharacter)
            {
                HidePanel(panelButtonCharacter);
                enteredCharacter = false;
            }

            if (enteredCompany)
            {
                HidePanel(panelButtonCompany);
                enteredCompany = false;
            }

            if (enteredPerson)
            {
                HidePanel(panelButtonPerson);
                enteredPerson = false;
            }
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            if (!enteredCompany)
                ShowAnimePanel(panelButtonCompany);

            enteredCompany = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (!enteredPerson)
                ShowAnimePanel(panelButtonPerson);

            enteredPerson = true;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (!enteredCharacter)
                ShowAnimePanel(panelButtonCharacter);

            enteredCharacter = true;
        }
    }
}
