using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.FeatureDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FeatureServices
{
    public class FeatureService(IFeatureRepository _featureRepository,
        IUnitOfWork _unitOfWork) : IFeatureService
    {
        public async Task TCreateAsync(CreateFeatureDto createDto)
        {
            var value = createDto.Adapt<Feature>();
            await _featureRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _featureRepository.GetByIdAsync(id);
            _featureRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFeatureDto>> TGetAllAsync()
        {
            var values = await _featureRepository.GetAllAsync();
            return values.Adapt<List<ResultFeatureDto>>();
        }

        public async Task<ResultFeatureDto> TGetByIdAsync(int id)
        {
            var value = await _featureRepository.GetByIdAsync(id);
            return value.Adapt<ResultFeatureDto>();
        }

        public async Task TUpdateAsync(UpdateFeatureDto updateDto)
        {
            var value = updateDto.Adapt<Feature>();
            _featureRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
