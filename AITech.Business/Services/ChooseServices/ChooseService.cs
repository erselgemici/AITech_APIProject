using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ChooseDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ChooseServices
{
    public class ChooseService(IChooseRepository _chooseRepository,
        IUnitOfWork _unitOfWork) : IChooseService
    {
        public async Task TCreateAsync(CreateChooseDto createDto)
        {
            var value = createDto.Adapt<Choose>();
            await _chooseRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _chooseRepository.GetByIdAsync(id);
            _chooseRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultChooseDto>> TGetAllAsync()
        {
            var values = await _chooseRepository.GetAllAsync();
            return values.Adapt<List<ResultChooseDto>>();
        }

        public async Task<ResultChooseDto> TGetByIdAsync(int id)
        {
            var value = await _chooseRepository.GetByIdAsync(id);
            return value.Adapt<ResultChooseDto>();
        }

        public async Task TUpdateAsync(UpdateChooseDto updateDto)
        {
            var value = updateDto.Adapt<Choose>();
            _chooseRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
