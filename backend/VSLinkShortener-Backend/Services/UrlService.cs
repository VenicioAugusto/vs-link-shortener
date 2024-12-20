using VSLinkShortener_Backend.Models;
using VSLinkShortener_Backend.Repositories;

namespace VSLinkShortener_Backend.Services
{
    public class UrlService
    {
        private readonly IUrlRepository _urlRepository;

        public UrlService(IUrlRepository urlRepository)
        {
            _urlRepository = urlRepository;
        }

        public async Task<Url> CreateShortUrlAsync(string originalUrl)
        {
            var shortenedUrl = GenerateShortenedUrl();
            var url = new Url
            {
                OriginalUrl = originalUrl,
                ShortenedUrl = shortenedUrl
            };

            return await _urlRepository.AddUrlAsync(url);
        }

        public async Task<Url?> GetUrlByIdAsync(string id)
        {
            return await _urlRepository.GetUrlByIdAsync(id);
        }

        public async Task<IEnumerable<Url>> GetAllUrlsAsync()
        {
            return await _urlRepository.GetAllUrlsAsync();
        }

        private string GenerateShortenedUrl()
        {
            string shortCode = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);

            return $"vslinkshortener-{shortCode}";
        }


    }
}
