using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _aboutRepository,
        IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var value = createDto.Adapt<About>();
            await _aboutRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _aboutRepository.GetByIdAsync(id);
            _aboutRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var values = await _aboutRepository.GetAllAsync();
            return values.Adapt<List<ResultAboutDto>>();
        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var value = await _aboutRepository.GetByIdAsync(id);
            return value.Adapt<ResultAboutDto>();
        }

        public async Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var value = updateDto.Adapt<About>();
            _aboutRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
