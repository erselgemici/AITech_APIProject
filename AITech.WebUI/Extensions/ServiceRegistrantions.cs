using AITech.WebUI.Services.AboutItemServices;
using AITech.WebUI.Services.AboutServices;
using AITech.WebUI.Services.BannerServices;
using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ChooseServices;
using AITech.WebUI.Services.FaqServices;
using AITech.WebUI.Services.FeatureServices;
using AITech.WebUI.Services.GeminiServices;
using AITech.WebUI.Services.ProjectServices;
using AITech.WebUI.Services.SocialServices;
using AITech.WebUI.Services.TestimonialServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AITech.WebUI.Extensions
{
    public static class ServiceRegistrantions
    {
        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IFaqService, FaqService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IChooseService, ChooseService>();
            services.AddHttpClient<IAboutItemService, AboutItemService>();
            services.AddHttpClient<ISocialService, SocialService>();


            services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
