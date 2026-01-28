using AITech.WebUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class GeminiController : Controller
    {
        private readonly GeminiApiService _geminiApiService;

        public GeminiController(GeminiApiService geminiApiService)
        {
            _geminiApiService = geminiApiService;
        }

        [HttpPost]
        public async Task<IActionResult> GetResponse(string prompt)
        {
            var answer = await _geminiApiService.GetGeminiResponseAsync(prompt);
            return Json(new { success = true, answer = answer });
        }
    }
}
