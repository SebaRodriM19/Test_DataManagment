using Exercise.ArtGallery_EF.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.Repositories
{
    public class QueryLinqRepository
    {
        private ArtGalleryContext _db;

        public QueryLinqRepository(ArtGalleryContext db)
        {
            _db = db;
        }

        public void QueryOne() 
        {
            var res = _db;
        }
        public void QueryTwo()
        {
        }
        public void QueryThree()
        {

        }
    }
}
