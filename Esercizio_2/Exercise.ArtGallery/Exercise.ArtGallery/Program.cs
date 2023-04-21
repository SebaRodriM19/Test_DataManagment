using Exercise.ArtGallery;
using Exercise.ArtGallery.Repositories;

var repo = new RepositoryQuery();
var service = new MainService(repo);
service.Run();