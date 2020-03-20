using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Roles
    {
        public Roles()
        {
            Personal = new HashSet<Personal>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
