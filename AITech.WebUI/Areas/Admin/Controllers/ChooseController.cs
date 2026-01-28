using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChooseController(IChooseService _chooseService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _chooseService.GetAllAsync();
            return View(values);
        }

        public IActionResult CreateChoose()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateChoose(CreateChooseDto createDto)
        {
            await _chooseService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateChoose(int id)
        {
            var value = await _chooseService.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateChoose(UpdateChooseDto updateDto)
        {
            await _chooseService.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteChoose(int id)
        {
            await _chooseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
