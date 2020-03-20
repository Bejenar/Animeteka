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

namespace Animeteka
{
    public partial class Form1 : Form
    {

        AnimetekaContext db;

        public Form1()
        {
            InitializeComponent();
            db = new AnimetekaContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            var result = db.Anime
                .Include(u => u.Atype)
                .Where(y => (atype.Text.Trim(new char[] {' '}) == "" )? true: y.Atype.AtypeName == atype.Text)
                .ToList();

            int i = 1;
            foreach(var a in result)
            {
                textBox1.Text += i++ + ". " + a.AnimeName +" [" + a.Atype.AtypeName +"]\r\n";
                
            }
        }



    }
}
