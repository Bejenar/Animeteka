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
    public partial class CustomCheckBox : CheckBox
    {
        /*public CustomCheckBox()
        {
            InitializeComponent();
        }*/

        public CustomCheckBox()
        {
            Image plus = Properties.Resources.plus;
            Image minus = Properties.Resources.minus;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            ImageList = new ImageList();
            ImageList.ImageSize = new Size(16, 16);
            ImageList.Images.Add(plus);
            ImageList.Images.Add(minus);

            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            TextImageRelation = TextImageRelation.ImageBeforeText;

            ImageIndex = 0;
            Checked = false;
            BackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            BackColorChanged += new EventHandler(this.setransp);

            CheckedChanged += new EventHandler(this.chkMyCheckBoxWithAnImage_CheckedChanged);
        }

        private void setransp(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void chkMyCheckBoxWithAnImage_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked)
                ImageIndex = 1;
            else
                ImageIndex = 0;

            BackColor = Color.Transparent;
        }

        /*protected override void OnPaint(PaintEventArgs pevent)
        {
        
            /*
            base.OnPaint(pevent);
            if (this.Checked)
            {
                //pevent.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 16, 16));
                pevent.Graphics.DrawImage(plus, new Rectangle(0, 0, 16, 16));
            }
            else
            {
                //pevent.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, 16, 16));
                pevent.Graphics.DrawImage(minus, new Rectangle(0, 0, 16, 16));
            }

            
        }*/

    }
}
