using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository,
        IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createDto)
        {
            var value = createDto.Adapt<Social>();
            await _socialRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _socialRepository.GetByIdAsync(id);
            _socialRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var values = await _socialRepository.GetAllAsync();
            return values.Adapt<List<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var value = await _socialRepository.GetByIdAsync(id);
            return value.Adapt<ResultSocialDto>();
        }

        public async Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var value = updateDto.Adapt<Social>();
            _socialRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
