using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace VSLinkShortener_Backend.Models
{
    public class Url
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortenedUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExpirationDate { get; set; }
    }
}
