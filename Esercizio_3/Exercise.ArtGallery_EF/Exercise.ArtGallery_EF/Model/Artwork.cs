using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.Model
{
    public class Artwork
    {
        public int IdArtwork { get; set; }
        public string Name { get; set; }
        public Museum IdMuseum { get; set; }
        public Artist IdArtist { get; set; }
        public Character? IdCharacter { get; set; }
        public virtual List<Museum> Museums { get; set; } = new();
        public virtual List<Artist> Artists { get; set; } = new();
        public virtual List<Character> Characters { get; set; } = new();
    }
}
