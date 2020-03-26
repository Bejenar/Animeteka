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
    public partial class AnimeCast : UserControl
    {
        private ICollection<Personal> roles;

        public AnimeCast()
        {
            InitializeComponent();
        }

        public AnimeCast(int animeId)
        {
            InitializeComponent();

            roles = Program.db.Personal
                            .Include(p => p.Person)
                            .Include(p => p.Role)
                            .Where(ch => ch.AnimeId == animeId)
                            .ToList();

            foreach (var role in roles)
            {
                var person = new PersonPreview(role);
                panel3.Controls.Add(person);
                person.Dock = DockStyle.Top;
            }

                
            
        }
    }
}
