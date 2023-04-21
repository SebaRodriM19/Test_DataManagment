using Exercise.ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery
{
    public class Constants
    {
        public const string ConnectionString =
       @"Server=ACADEMYNETUD04\SQLEXPRESS; Database=ArtGallery; Integrated Security=true; TrustServerCertificate=True";
        public const string queryOne = @"  select m.MuseumName, a.Id_Artwork,a.NameArtwork,ar.NameArtist
from Artwork a join Artist ar on a.Id_Artist = ar.Id_Artist join Museum m on m.Id_Museum = a.Id_Museum
where ar.Country = 'Italia'";
        public const string queryTwo = @"select ar.NameArtist
from Artwork a join Artist ar on a.Id_Artist = ar.Id_Artist join Museum m on m.Id_Museum = a.Id_Museum
where m.City = 'Parigi'";
        public const string queryThree = @"select m.City
from Artwork a left join Character c on c.Id_Character = a.Id_Charachter join Museum m on m.Id_Museum = a.Id_Museum
where c.NameCharacter = 'Flora'";
    }
}
