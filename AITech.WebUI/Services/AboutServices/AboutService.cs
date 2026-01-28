using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;
        public AboutService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutDto>>("Abouts");
        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutDto>($"Abouts/{id}");
        }

        public async Task CreateAsync(CreateAboutDto createAboutDto)
        {
            await _client.PostAsJsonAsync("Abouts", createAboutDto);
        }

        public async Task UpdateAsync(UpdateAboutDto updateAboutDto)
        {
            await _client.PutAsJsonAsync("Abouts", updateAboutDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Abouts/{id}");
        }
    }
}
