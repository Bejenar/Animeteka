using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual UserRoles UserRoles { get; set; }
    }
}
