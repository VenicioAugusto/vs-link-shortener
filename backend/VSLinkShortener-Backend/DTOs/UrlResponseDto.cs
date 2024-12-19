namespace VSLinkShortener_Backend.DTOs
{
    public class UrlResponseDto
    {
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortenedUrl { get; set; } = string.Empty;
    }
}
