using AITech.Business.Services;
using AITech.DTO.GeminiDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeminiController : ControllerBase
    {
        private readonly GeminiService _geminiService;

        public GeminiController(GeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost]
        public async Task<IActionResult> GenerateText([FromBody] PromptReqDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Prompt))
                return BadRequest("Lütfen bir şeyler yazın.");

            var result = await _geminiService.GenerateContentAsync(request.Prompt);

            return Ok(new { Answer = result });
        }
    }
}
