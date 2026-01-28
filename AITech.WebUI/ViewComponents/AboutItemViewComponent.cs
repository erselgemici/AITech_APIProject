using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutItemViewComponent : ViewComponent
    {
        private readonly IAboutItemService _aboutItemService;

        public _AboutItemViewComponent(IAboutItemService aboutItemService)
        {
            _aboutItemService = aboutItemService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutItemService.GetAllAsync();
            return View(values);
        }
    }
}
