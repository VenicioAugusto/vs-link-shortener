using VSLinkShortener_Backend.Models;

namespace VSLinkShortener_Backend.Repositories
{
    public interface IUrlRepository
    {
        Task<Url> AddUrlAsync(Url url);
        Task<Url> GetUrlByIdAsync(string id);
        Task<IEnumerable<Url>> GetAllUrlsAsync();
    }
}
