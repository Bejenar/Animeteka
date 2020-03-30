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
    public partial class AnimeEdit : Form
    {
        Anime anime; 

        public AnimeEdit()
        {
            InitializeComponent();
        }

        public AnimeEdit(Anime anime)
        {
            InitializeComponent();

            this.anime = anime;

            textBox1.Text = anime.AnimeName;
            textBox2.Text = anime.AnimeNameEn;

            var types = Program.db.AnimeType.ToList();
            foreach (var t in types)
            {
                comboBox1.Items.Add(t);
                if (t.AtypeId == anime.AtypeId)
                    comboBox1.SelectedItem = comboBox1.Items[comboBox1.Items.Count - 1];
            }
             

            var studios = Program.db.Studio.ToList();
            foreach (var s in studios)
            {
                comboBox2.Items.Add(s);
                if(s.StudioId == anime.StudioId)
                    comboBox2.SelectedItem = comboBox2.Items[comboBox2.Items.Count - 1];
            }
            comboBox2.SelectedItem = comboBox2.Items[0];

            dateTimePicker1.Value = (DateTime)anime.AirDate;
            dateTimePicker2.Value = (DateTime)anime.ReleaseDate;
            textBox7.Text += anime.EpDuration;
            textBox8.Text += anime.EpCount;
            textBox9.Text += anime.EpAired;
            textBox10.Text += anime.AnimeUrl;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anime.AnimeName = textBox1.Text;
            Program.db.Anime.Update(anime);
        }
    }
}
