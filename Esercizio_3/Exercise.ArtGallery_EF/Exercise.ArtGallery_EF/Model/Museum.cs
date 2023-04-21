using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.Model
{
    public class Museum
    {
        public int IdMuseum { get; set; }
        public string MuseumName { get; set; }
        public string City { get; set; }

        public virtual Artwork Artwork { get; set; }
    }
}
