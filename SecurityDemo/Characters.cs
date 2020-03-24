using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Characters
    {
        public Characters()
        {
            CharacterAnime = new HashSet<CharacterAnime>();
        }

        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string CharacterNameEn { get; set; }
        public string ImgUrl { get; set; }

        public virtual ICollection<CharacterAnime> CharacterAnime { get; set; }
    }
}
