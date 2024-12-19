using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VSLinkShortener_Backend.DTOs;
using VSLinkShortener_Backend.Models;
using VSLinkShortener_Backend.Services;

namespace VSLinkShortener_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlsController : ControllerBase
    {
        private readonly UrlService _urlService;

        public UrlsController(UrlService urlService)
        {
            _urlService = urlService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShortUrl([FromBody] UrlCreateDto urlDto)
        {
            if (string.IsNullOrEmpty(urlDto.OriginalUrl))
                return BadRequest("Original URL is required.");

            var result = await _urlService.CreateShortUrlAsync(urlDto.OriginalUrl);

            return Ok(new UrlResponseDto
            {
                OriginalUrl = result.OriginalUrl,
                ShortenedUrl = result.ShortenedUrl
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOriginalUrl(string id)
        {
            var result = await _urlService.GetUrlByIdAsync(id);
            if (result == null)
                return NotFound("URL not found.");

            return Redirect(result.OriginalUrl);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUrls()
        {
            var urls = await _urlService.GetAllUrlsAsync();
            return Ok(urls);
        }
    }
}
