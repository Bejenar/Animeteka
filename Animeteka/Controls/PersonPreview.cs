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
    public partial class PersonPreview : UserControl
    {
        public PersonPreview()
        {
            InitializeComponent();
        }

        public PersonPreview(Personal person)
        {
            InitializeComponent();

            if (person != null)
            {
                pictureBox1.LoadAsync(person.Person.PersonUrl);
                label1.Text = person.Person.PersonName;
                label3.Text = person.Role.RoleName;
                Console.WriteLine(pictureBox1.ImageLocation);
            }
        }
    }
}
