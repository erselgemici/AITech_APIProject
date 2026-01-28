using AITech.WebUI.DTOs.AboutItemDtos;
using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutItemController(IAboutItemService _aboutItemService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _aboutItemService.GetAllAsync();
            return View(values);
        }

        public IActionResult CreateAboutItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemDto createDto)
        {
            await _aboutItemService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var value = await _aboutItemService.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemDto updateDto)
        {
            await _aboutItemService.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
