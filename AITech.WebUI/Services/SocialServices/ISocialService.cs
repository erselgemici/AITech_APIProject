using AITech.WebUI.DTOs.SocialDtos;

namespace AITech.WebUI.Services.SocialServices
{
    public interface ISocialService
    {
        Task<List<ResultSocialDto>> GetAllAsync();
        Task<UpdateSocialDto> GetByIdAsync(int id);
        Task CreateAsync(CreateSocialDto createDto);
        Task UpdateAsync(UpdateSocialDto updateDto);
        Task DeleteAsync(int id);
    }
}
