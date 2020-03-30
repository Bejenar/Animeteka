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

            dateTimePicker1.Value = (DateTime)anime.AirDate;
            if(anime.ReleaseDate != null)
            dateTimePicker2.Value = (DateTime)anime.ReleaseDate;
            textBox7.Text += anime.EpDuration;
            textBox8.Text += anime.EpCount;
            textBox9.Text += anime.EpAired;
            textBox10.Text += anime.AnimeUrl;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anime.AnimeName = textBox1.Text;
            anime.AnimeNameEn = textBox2.Text;
            anime.Atype = (AnimeType)comboBox1.SelectedItem;
            anime.Studio = (Studio)comboBox2.SelectedItem;
            anime.AirDate = dateTimePicker1.Value;
            anime.ReleaseDate = dateTimePicker2.Value;
            anime.EpDuration = (short)Convert.ToInt32(textBox7.Text);
            anime.EpCount = (short)Convert.ToInt32(textBox8.Text);
            anime.EpAired = (short)Convert.ToInt32(textBox9.Text);
            anime.AnimeUrl = textBox10.Text;

            Program.db.Anime.Update(anime);
        }
    }
}
