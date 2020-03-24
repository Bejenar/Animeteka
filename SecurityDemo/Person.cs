using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Person
    {
        public Person()
        {
            CharacterAnime = new HashSet<CharacterAnime>();
            Personal = new HashSet<Personal>();
        }

        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonNameEn { get; set; }
        public DateTime? DateB { get; set; }
        public string ImgUrl { get; set; }

        public virtual ICollection<CharacterAnime> CharacterAnime { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
