using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class AnimeCharacterView
    {
        public int? AnimeId { get; set; }
        public string CharacterName { get; set; }
        public bool? IsMain { get; set; }
        public string PersonName { get; set; }
    }
}
