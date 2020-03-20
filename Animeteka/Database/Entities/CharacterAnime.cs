using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class CharacterAnime
    {
        public int CharAnimeId { get; set; }
        public int? AnimeId { get; set; }
        public int? CharacterId { get; set; }
        public bool? IsMain { get; set; }
        public int? PersonId { get; set; }

        public virtual Anime Anime { get; set; }
        public virtual Characters Character { get; set; }
        public virtual Person Person { get; set; }
    }
}
