using AITech.Business.Services.GenericServices;
using AITech.WebUI.DTOs.TestimonialDtos;

namespace AITech.Business.Services.TestimonialServices
{
    public interface ITestimonialService : IGenericService<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
    }
}
