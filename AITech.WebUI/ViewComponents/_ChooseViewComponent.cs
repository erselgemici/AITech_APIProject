using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _ChooseViewComponent(IChooseService _chooseService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _chooseService.GetAllAsync();
            var choose = values.FirstOrDefault();
            return View(choose);
        }
    }
}
