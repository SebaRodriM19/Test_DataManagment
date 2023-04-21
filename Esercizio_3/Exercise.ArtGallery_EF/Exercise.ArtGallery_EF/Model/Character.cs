using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.Model
{
    public class Character
    {
        public int IdCharachter { get; set; }
        public string Name { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}
