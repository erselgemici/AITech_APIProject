using AITech.WebUI.DTOs.FeatureDtos;

namespace AITech.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;
        public FeatureService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task<List<ResultFeatureDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFeatureDto>>("Features");
        }

        public async Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFeatureDto>($"Features/{id}");
        }

        public async Task CreateAsync(CreateFeatureDto createFeatureDto)
        {
            await _client.PostAsJsonAsync("Features", createFeatureDto);
        }

        public async Task UpdateAsync(UpdateFeatureDto updateFeatureDto)
        {
            await _client.PutAsJsonAsync("Features", updateFeatureDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Features/{id}");
        }
    }
}
