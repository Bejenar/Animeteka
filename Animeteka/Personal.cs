using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Personal
    {
        public int? PersonId { get; set; }
        public int? AnimeId { get; set; }
        public byte? RoleId { get; set; }

        public virtual Anime Anime { get; set; }
        public virtual Person Person { get; set; }
        public virtual Roles Role { get; set; }
    }
}
