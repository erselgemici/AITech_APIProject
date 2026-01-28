using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _aboutItemRepository,
        IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createDto)
        {
            var value = createDto.Adapt<AboutItem>();
            await _aboutItemRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _aboutItemRepository.GetByIdAsync(id);
            _aboutItemRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutItemDto>> TGetAllAsync()
        {
            var values = await _aboutItemRepository.GetAllAsync();
            return values.Adapt<List<ResultAboutItemDto>>();
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var value = await _aboutItemRepository.GetByIdAsync(id);
            return value.Adapt<ResultAboutItemDto>();
        }

        public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var value = updateDto.Adapt<AboutItem>();
            _aboutItemRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
