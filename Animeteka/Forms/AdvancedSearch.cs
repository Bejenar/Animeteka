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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();

            // populate anime type filter
            var types = Program.db.AnimeType.ToList();
            foreach(var t in types)
            {
                Type.Items.Add(t);
            }

            // populate genre filter
            var genres = Program.db.Genre.ToList();
            foreach(var g in genres)
            {
                Genre.Items.Add(g);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var atype = (AnimeType)Type.SelectedItem;

            var result = Program.db.Anime
                .Where(y => (atype == null) ? true : y.AtypeId == atype.AtypeId)
                .Select(s => new { s.AnimeName, s.Atype.AtypeName })
                .ToList();

            int i = 1;
            foreach (var a in result)
            {
                textBox2.Text += i++ + ". " + a.AnimeName + " [" + a.AtypeName + "]\r\n";

            }
        }
    }
}
