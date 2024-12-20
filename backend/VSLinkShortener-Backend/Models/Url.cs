using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace VSLinkShortener_Backend.Models
{
    public class Url
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [Required]
        [BsonElement("OriginalUrl")]
        public string OriginalUrl { get; set; } = string.Empty;

        [BsonElement("ShortenedUrl")]
        public string ShortenedUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExpirationDate { get; set; }
    }
}
