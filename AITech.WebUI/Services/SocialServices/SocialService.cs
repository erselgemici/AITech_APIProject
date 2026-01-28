using AITech.WebUI.DTOs.SocialDtos;

namespace AITech.WebUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _client;
        public SocialService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task CreateAsync(CreateSocialDto createDto)
        {
            await _client.PostAsJsonAsync("Socials", createDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Socials/{id}");
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultSocialDto>>("Socials");
        }

        public async Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateSocialDto>($"Socials/{id}");
        }

        public async Task UpdateAsync(UpdateSocialDto updateDto)
        {
            await _client.PutAsJsonAsync("Socials", updateDto);
        }
    }
}
