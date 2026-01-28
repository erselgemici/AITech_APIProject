using AITech.WebUI.DTOs.ChooseDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client;
        public ChooseService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultChooseDto>>("Chooses");
        }

        public async Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateChooseDto>($"Chooses/{id}");
        }

        public async Task CreateAsync(CreateChooseDto createChooseDto)
        {
            await _client.PostAsJsonAsync("Chooses", createChooseDto);
        }

        public async Task UpdateAsync(UpdateChooseDto updateChooseDto)
        {
            await _client.PutAsJsonAsync("Chooses", updateChooseDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Chooses/{id}");
        }
    }
}
