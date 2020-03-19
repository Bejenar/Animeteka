using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class AnimeView
    {
        public int AnimeId { get; set; }
        public string AnimeName { get; set; }
        public string StudioName { get; set; }
        public string AtypeName { get; set; }
        public DateTime? AirDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public short? EpDuration { get; set; }
        public short? EpCount { get; set; }
        public short? EpAired { get; set; }
    }
}
