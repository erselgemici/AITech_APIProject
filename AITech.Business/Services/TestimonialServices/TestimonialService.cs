using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.Entity.Entities;
using AITech.WebUI.DTOs.TestimonialDtos;
using Mapster;

namespace AITech.Business.Services.TestimonialServices
{
    public class TestimonialService(ITestimonialRepository _testimonialRepository,
        IUnitOfWork _unitOfWork) : ITestimonialService
    {
        public async Task TCreateAsync(CreateTestimonialDto createDto)
        {
            var value = createDto.Adapt<Testimonial>();
            await _testimonialRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _testimonialRepository.GetByIdAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTestimonialDto>> TGetAllAsync()
        {
            var values = await _testimonialRepository.GetAllAsync();
            return values.Adapt<List<ResultTestimonialDto>>();
        }

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
            var value = await _testimonialRepository.GetByIdAsync(id);
            return value.Adapt<ResultTestimonialDto>();
        }

        public async Task TUpdateAsync(UpdateTestimonialDto updateDto)
        {
            var value = updateDto.Adapt<Testimonial>();
            _testimonialRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
