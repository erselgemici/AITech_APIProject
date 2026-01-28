using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutViewComponent(IAboutService _aboutService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAsync();
            var about = values.FirstOrDefault();
            return View(about);
        }
    }
}
