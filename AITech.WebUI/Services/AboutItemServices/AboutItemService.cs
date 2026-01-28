using AITech.WebUI.DTOs.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;
        public AboutItemService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task CreateAsync(CreateAboutItemDto createDto)
        {
            await _client.PostAsJsonAsync("AboutItems", createDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"AboutItems/{id}");
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutItemDto>>("AboutItems");
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutItemDto>($"AboutItems/{id}");
        }

        public async Task UpdateAsync(UpdateAboutItemDto updateDto)
        {
            await _client.PutAsJsonAsync("AboutItems", updateDto);
        }
    }
}
