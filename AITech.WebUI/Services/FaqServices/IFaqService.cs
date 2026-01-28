using AITech.WebUI.DTOs.FaqDtos;

namespace AITech.WebUI.Services.FaqServices
{
    public interface IFaqService
    {
        Task<List<ResultFaqDto>> GetAllAsync();
        Task<UpdateFaqDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFaqDto createFaqDto);
        Task UpdateAsync(UpdateFaqDto updateFaqDto);
        Task DeleteAsync(int id);
    }
}
