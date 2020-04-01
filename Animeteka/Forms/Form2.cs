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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var roles = Program.db.CharacterAnime
                    .Include(ca => ca.Anime)
                    .Include(ca => ca.Character)
                    .Where(p => p.PersonId == 65)
                    .AsEnumerable()
                    .GroupBy(ca => ca.CharacterId)
                    .ToList();

            foreach(var c in roles)
            {
                flowLayoutPanel1.Controls.Add(new CharacterInAnimes(c));
            }
        }

        private void customCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
