using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeteka.Controls
{
    public partial class AnimeWork : UserControl
    {
        private Personal work;

        public AnimeWork()
        {
            InitializeComponent();
        }

        public AnimeWork(Personal work)
        {
            InitializeComponent();

            this.work = work;
            pictureBox1.LoadAsync(work.Anime.AnimeUrl);
            title.Text = work.Anime.AnimeName;
            kind.Text = work.Anime.Atype.AtypeName;
            if(work.Anime.AirDate != null)
            year.Text = work.Anime.AirDate.Value.Year.ToString();
            role.Text = work.Role.RoleName;

            toolTip1.SetToolTip(title, title.Text);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AnimeWork_Load(object sender, EventArgs e)
        {

        }
    }
}
