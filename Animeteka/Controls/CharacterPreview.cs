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
    public partial class CharacterPreview : UserControl
    {
        Characters character;

        public CharacterPreview()
        {
            InitializeComponent();
        }

        public CharacterPreview(Characters character)
        {
            InitializeComponent();

            if (character != null)
            {
                this.character = character;
                pictureBox1.LoadAsync(character.CharacterUrl);
                label1.Text = character.CharacterName;
                Console.WriteLine(pictureBox1.ImageLocation);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            var frm = new CharacterInfo(character);
            frm.Location = this.ParentForm.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.ParentForm.Show(); };
            frm.Show();
            this.ParentForm.Hide();
        }
    }
}
