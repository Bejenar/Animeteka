using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Animeteka.Controls
{
    public partial class AdvancedSearchControl : UserControl
    {

        public AdvancedSearchControl()
        {
            InitializeComponent();
            
        }



        private void Type_check_CheckedChanged(object sender, EventArgs e)
        {
            var chb = (CheckBox)sender;

            if (!chb.Checked)
            {
                foreach(Control c in chb.Parent.Parent.Controls)
                {
                    if (!c.Equals(chb.Parent))
                    {
                        c.Visible = false;
                    }
                }
            }
            else
            {
                foreach (Control c in chb.Parent.Parent.Controls)
                {
                        c.Visible = true;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
