using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Animeteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TODO: temporary fix of first query slowness issue 
            var cache = Program.db.Characters.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            var result = Program.db.Anime
                .Where(y => (atype.Text.Trim(new char[] { ' ' }) == "") ? true : y.Atype.AtypeName == atype.Text)
                .Select(s => new {s.AnimeName, s.Atype.AtypeName })
                .ToList();




            int i = 1;
            foreach (var a in result)
            { 
                textBox1.Text += i++ + ". " + a.AnimeName + " [" + a.AtypeName + "]\r\n";

            }
        }



    }
}
