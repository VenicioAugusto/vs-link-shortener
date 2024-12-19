using MongoDB.Driver;
using VSLinkShortener_Backend.Models;

namespace VSLinkShortener_Backend.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        private readonly IMongoCollection<Url> _urlCollection;

        public UrlRepository(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("VSLinksDb");
            _urlCollection = database.GetCollection<Url>("Urls");
        }

        public async Task<Url> AddUrlAsync(Url url)
        {
            await _urlCollection.InsertOneAsync(url);
            return url;
        }

        public async Task<Url> GetUrlByIdAsync(string id)
        {
            return await _urlCollection.Find(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Url>> GetAllUrlsAsync()
        {
            return await _urlCollection.Find(_ => true).ToListAsync();
        }
    }
}
