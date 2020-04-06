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
                // TODO: check roles tables
                if(user.Login == "admin")
                {
                    Program.is_admin = true;
                }

                OpenWelcomePage();
            }
            else
            {
                Console.WriteLine("wrong password");
            }
           
        }

        private void OpenWelcomePage()
        {
            var frm = new WelcomePage();
            frm.Show();
            this.Close();
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenWelcomePage();
        }
    }
}
