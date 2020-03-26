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
    public partial class CharacterPreview : UserControl
    {
        public CharacterPreview()
        {
            InitializeComponent();
        }

        public CharacterPreview(Characters character)
        {
            InitializeComponent();

            if (character != null)
            {
                pictureBox1.LoadAsync(character.CharacterUrl);
                label1.Text = character.CharacterName;
                Console.WriteLine(pictureBox1.ImageLocation);
            }
        }
    }
}
