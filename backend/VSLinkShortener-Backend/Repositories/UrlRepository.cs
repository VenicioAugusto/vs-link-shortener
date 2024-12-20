using MongoDB.Driver;
using VSLinkShortener_Backend.Config;
using VSLinkShortener_Backend.Models;
using Microsoft.Extensions.Options;

namespace VSLinkShortener_Backend.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        private readonly IMongoCollection<Url> _urlCollection;

        public UrlRepository(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _urlCollection = database.GetCollection<Url>("Urls");
        }

        public async Task<Url> AddUrlAsync(Url url)
        {
            //await _urlCollection.InsertOneAsync(url);
            //return url;

            try
            {
                if (url == null)
                    throw new ArgumentNullException(nameof(url));

                await _urlCollection.InsertOneAsync(url);
                Console.WriteLine($"Inserted URL: {url.OriginalUrl} -> {url.ShortenedUrl}");
                return url;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting URL: {ex.Message}");
                throw;
            }
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
