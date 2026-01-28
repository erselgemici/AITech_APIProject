using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAsync();
            return View(values);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createDto)
        {
            await _aboutService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAbout(int id)
        {
            var value = await _aboutService.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateDto)
        {
            await _aboutService.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
