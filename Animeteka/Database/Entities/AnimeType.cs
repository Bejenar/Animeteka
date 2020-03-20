using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class AnimeType
    {
        public AnimeType()
        {
            Anime = new HashSet<Anime>();
        }

        public byte AtypeId { get; set; }
        public string AtypeName { get; set; }

        public virtual ICollection<Anime> Anime { get; set; }
    }
}
