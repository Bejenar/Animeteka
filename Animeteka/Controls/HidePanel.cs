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
    public partial class HidePanel : UserControl
    {
        [Category("Custom")]
        public FlowLayoutPanel PanelToHide { get; set; }

        [Category("Custom")]
        public Image ImageShown { get; set; }

        [Category("Custom")]
        public Image ImageHidden { get; set; }

        [Category("Custom")]
        public Image Image { get { return pictureBox1.Image; } set { pictureBox1.Image = value; } }


        public HidePanel()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelToHide != null)
            {
                if (PanelToHide.Visible)
                {
                    // change pic
                    pictureBox1.Image = ImageHidden;
                    PanelToHide.Visible = false;
                }
                else
                {
                    //change pic
                    pictureBox1.Image = ImageShown;
                    PanelToHide.Visible = true;
                }
            }
        }
    }
}
