using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery.Models
{
    public class Artwork
    {
        public int IdArtwork { get; set; }
        public string Name { get; set; }
        public Museum IdMuseum { get; set; }
        public Artist IdArtist { get; set; }
        public Character? IdCharacter { get; set; }
    }
}
