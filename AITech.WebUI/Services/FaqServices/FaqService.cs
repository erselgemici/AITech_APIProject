using AITech.WebUI.DTOs.FaqDtos;

namespace AITech.WebUI.Services.FaqServices
{
    public class FaqService : IFaqService
    {
        private readonly HttpClient _client;
        public FaqService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task<List<ResultFaqDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFaqDto>>("Faqs");
        }

        public async Task<UpdateFaqDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFaqDto>($"Faqs/{id}");
        }

        public async Task CreateAsync(CreateFaqDto createFaqDto)
        {
            await _client.PostAsJsonAsync("Faqs", createFaqDto);
        }

        public async Task UpdateAsync(UpdateFaqDto updateFaqDto)
        {
            await _client.PutAsJsonAsync("Faqs", updateFaqDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Faqs/{id}");
        }
    }
}
