using AITech.WebUI.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _FaqViewComponent(IFaqService _faqService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _faqService.GetAllAsync();
            return View(values);
        }
    }
}
