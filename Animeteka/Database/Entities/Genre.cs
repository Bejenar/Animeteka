using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Genre
    {
        public Genre()
        {
            AnimeAndGenre = new HashSet<AnimeAndGenre>();
        }

        public byte GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<AnimeAndGenre> AnimeAndGenre { get; set; }

        public override string ToString()
        {
            return GenreName;
        }
    }
}
