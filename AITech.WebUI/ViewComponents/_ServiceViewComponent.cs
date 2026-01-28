using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _ServiceViewComponent(IFeatureService _featureService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllAsync();
            return View(values);
        }
    }
}
