using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new AnimetekaContext();

            var result = db.Anime.ToList();

            for(int i = 1; i <= 40; i++)
            {
                textBox1.Text += i + ". " + result[i].AnimeName + "\r\n";
                
            }
        }



    }
}
