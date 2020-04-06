using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class AnimeAndGenre
    {
        public int? AnimeId { get; set; }
        public byte? GenreId { get; set; }

        public virtual Anime Anime { get; set; }
        public virtual Genre Genre { get; set; }

        public override string ToString()
        {
            return Genre.GenreName ?? GenreId.ToString();
        }
    }
}
