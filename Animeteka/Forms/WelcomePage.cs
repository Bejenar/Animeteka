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
        public WelcomePage()
        {
            // TODO: temporary fix of first query slowness issue 
            var cache = Program.db.Characters.ToList();

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
    }
}
