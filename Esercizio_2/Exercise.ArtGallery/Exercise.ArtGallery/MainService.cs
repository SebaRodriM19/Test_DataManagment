using Exercise.ArtGallery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery
{
    public class MainService 
    {
        private RepositoryQuery _repositoryQuery;

        public MainService(RepositoryQuery repositoryQuery)
        {
            _repositoryQuery = repositoryQuery;
        }
        public void Run()
        {
            _repositoryQuery.QueryOne();
            Console.WriteLine();
            Console.WriteLine();
            _repositoryQuery.QueryTwo();
            Console.WriteLine();
            Console.WriteLine();
           _repositoryQuery.QueryThree();
        }
    }
}
