using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Security;

namespace Animeteka.Forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = Program.db.User.Where(u => u.Login == login.Text).First();

            if (Hashing.ValidatePassword(password.Text, user.Password))
            {
                var frm = new WelcomePage();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { Application.Exit(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("wrong password");
            }
           
        }
    }
}
