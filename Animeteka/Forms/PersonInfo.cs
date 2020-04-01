using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Controls;
using Microsoft.EntityFrameworkCore;

namespace Animeteka.Forms
{
    public partial class PersonInfo : Form
    {
        Person person;
        ICollection<Personal> works;
        //ICollection<Characters> roles;

        public PersonInfo()
        {
            InitializeComponent();
        }

        public PersonInfo(Person person)
        {
            InitializeComponent();

            this.person = person;

            pictureBox1.LoadAsync(person.PersonUrl);
            labelName.Text = person.PersonName;
            labelNameEn.Text = person.PersonNameEn;
            labelBirthday.Text = person.DateB.Value.ToLongDateString();

            // roles count
            var rolesCount = Program.db.Personal
                        .Where(w => w.PersonId == person.PersonId)
                        .GroupBy(w => w.Role.RoleName)
                        .Select(group => new { Role = group.Key, count = group.Count() })
                        .AsEnumerable()
                        .Concat
                        (
                new[]
                {
                  new  { Role = "Сейю", count = Program.db.CharacterAnime
                        .Where(ch => ch.PersonId == person.PersonId)
                        .Select(ch => ch.CharacterId)
                        .ToList()
                        .Distinct()
                        .Count() }
                }
                        
                        ).OrderBy(c => c.count, Comparer<int>.Create((o1, o2) => o2 - o1) ).Take(3).ToList();

            foreach (var a in rolesCount)
            {
                var l = new Label();
                l.Font = labelName.Font;
                l.Text = a.Role + ": " + a.count;
                l.AutoSize = true;
                l.Padding = new Padding(0, 0, 0, 6);
                flowLayoutPanel3.Controls.Add(l);
                Console.WriteLine(a.Role + " - " + a.count);
            }
                                


            //works
            works = Program.db.Personal
                        .Include(p => p.Anime)
                            .ThenInclude(a => a.Atype)
                        .Include(p => p.Role)
                        .Where(p => p.PersonId == person.PersonId)
                        .ToList();

            works = works
                .Distinct()
                .ToList();

            foreach (var work in works)
            {
                flowLayoutPanel1.Controls.Add(new AnimeWork(work));
            }

            //roles 
            var roles = Program.db.CharacterAnime
                    .Include(ca => ca.Anime)
                    .Include(ca => ca.Character)
                    .Where(p => p.PersonId == person.PersonId)
                    .AsEnumerable()
                    .GroupBy(ca => ca.CharacterId)
                    .ToList();

            foreach (var c in roles)
            {
                flowLayoutPanel2.Controls.Add(new CharacterInAnimes(c));
            }

        }

        private void PersonInfo_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.MaximumSize = new Size(this.Width, 900000);
            flowLayoutPanel2.MaximumSize = new Size(this.Width, 900000);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Visible = false;
            }
            else
            {
                flowLayoutPanel1.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Visible)
            {
                flowLayoutPanel2.Visible = false;
            }
            else
            {
                flowLayoutPanel2.Visible = true;
            }
        }
    }
}
