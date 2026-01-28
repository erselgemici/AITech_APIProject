using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _BannerViewComponent(IBannerService _bannerService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetAllAsync();
            var activeBanner = values.Where(x => x.IsActive).FirstOrDefault();
            return View(activeBanner);
        }
    }
}
