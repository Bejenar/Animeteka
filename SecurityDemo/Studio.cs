using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Studio
    {
        public Studio()
        {
            Anime = new HashSet<Anime>();
        }

        public int StudioId { get; set; }
        public string StudioName { get; set; }

        public virtual ICollection<Anime> Anime { get; set; }
    }
}
