using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class UserRoles
    {
        public int? UserId { get; set; }
        public int? Role { get; set; }

        public virtual User User { get; set; }
    }
}
