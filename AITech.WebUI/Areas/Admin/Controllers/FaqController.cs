using AITech.WebUI.DTOs.FaqDtos;
using AITech.WebUI.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqController(IFaqService _faqService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _faqService.GetAllAsync();
            return View(values);
        }

        public IActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaq(CreateFaqDto createDto)
        {
            await _faqService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateFaq(int id)
        {
            var value = await _faqService.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFaq(UpdateFaqDto updateDto)
        {
            await _faqService.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            await _faqService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
