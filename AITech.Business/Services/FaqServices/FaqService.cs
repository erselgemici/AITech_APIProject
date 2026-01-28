using AITech.DataAccess.Repositories.FaqRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FaqDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FaqServices
{
    public class FaqService(IFaqRepository _faqRepository,
        IUnitOfWork _unitOfWork) : IFaqService
    {
        public async Task TCreateAsync(CreateFaqDto createDto)
        {
            var value = createDto.Adapt<FAQ>();
            await _faqRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _faqRepository.GetByIdAsync(id);
            _faqRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFaqDto>> TGetAllAsync()
        {
            var values = await _faqRepository.GetAllAsync();
            return values.Adapt<List<ResultFaqDto>>();
        }

        public async Task<ResultFaqDto> TGetByIdAsync(int id)
        {
            var value = await _faqRepository.GetByIdAsync(id);
            return value.Adapt<ResultFaqDto>();
        }

        public async Task TUpdateAsync(UpdateFaqDto updateDto)
        {
            var value = updateDto.Adapt<FAQ>();
            _faqRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
