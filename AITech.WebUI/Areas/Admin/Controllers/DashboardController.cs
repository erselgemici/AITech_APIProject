using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.FeatureServices;
using AITech.WebUI.Services.ProjectServices;
using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController(IProjectService _projectService,
                                     ICategoryService _categoryService,
                                     ITestimonialService _testimonialService,
                                     IFeatureService _featureService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            // 1. Verileri Servislerden Çekiyoruz
            var projects = await _projectService.GetAllAsync();
            var testimonials = await _testimonialService.GetAllAsync();
            var categories = await _categoryService.GetAllAsync();
            var features = await _featureService.GetAllAsync();

            // 2. İstatistik Kartları İçin Sayıları ViewBag'e Atıyoruz
            ViewBag.ProjectCount = projects?.Count ?? 0;
            ViewBag.TestimonialCount = testimonials?.Count ?? 0;
            ViewBag.CategoryCount = categories?.Count ?? 0;
            ViewBag.FeatureCount = features?.Count ?? 0;

            // 3. Tablo İçin Son 5 Projeyi Alıyoruz (Tersten Sıralayarak)
            // Projeler null gelirse boş liste oluştur ki foreach patlamasın.
            if (projects != null)
            {
                ViewBag.LastProjects = projects.OrderByDescending(x => x.Id).Take(5).ToList();
            }
            else
            {
                ViewBag.LastProjects = new List<AITech.WebUI.DTOs.ProjectDtos.ResultProjectDto>();
            }

            return View();
        }
    }
}
