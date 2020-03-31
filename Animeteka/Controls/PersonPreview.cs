using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Forms;

namespace Animeteka.Controls
{
    public partial class PersonPreview : UserControl
    {
        Person person;

        public PersonPreview()
        {
            InitializeComponent();
        }

        public PersonPreview(Personal person)
        {
            InitializeComponent();

            this.person = person.Person;
            if (person != null)
            {
                this.person = person.Person;
                pictureBox1.LoadAsync(person.Person.PersonUrl);
                label1.Text = person.Person.PersonName;
                label3.Text = person.Role.RoleName;
                Console.WriteLine(pictureBox1.ImageLocation);
            }
        }

        public PersonPreview(Person person)
        {
            InitializeComponent();

            this.person = person;
            if(person != null)
            {
                pictureBox1.LoadAsync(person.PersonUrl);
                label1.Text = person.PersonName;
                label3.Text = "Сейю";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            var frm = new PersonInfo(person);
            frm.Location = this.ParentForm.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.ParentForm.Show(); };
            frm.Show();
            this.ParentForm.Hide();
        }
    }
}
