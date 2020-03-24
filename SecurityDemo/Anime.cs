using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Anime
    {
        public Anime()
        {
            AnimeAndGenre = new HashSet<AnimeAndGenre>();
            CharacterAnime = new HashSet<CharacterAnime>();
            Personal = new HashSet<Personal>();
        }

        public int AnimeId { get; set; }
        public string AnimeName { get; set; }
        public string AnimeNameEn { get; set; }
        public byte? AtypeId { get; set; }
        public int? StudioId { get; set; }
        public DateTime? AirDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public short? EpDuration { get; set; }
        public short? EpCount { get; set; }
        public short? EpAired { get; set; }
        public string ImgUrl { get; set; }

        public virtual AnimeType Atype { get; set; }
        public virtual Studio Studio { get; set; }
        public virtual ICollection<AnimeAndGenre> AnimeAndGenre { get; set; }
        public virtual ICollection<CharacterAnime> CharacterAnime { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
