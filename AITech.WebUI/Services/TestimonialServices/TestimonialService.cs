using AITech.WebUI.DTOs.TestimonialDtos;

namespace AITech.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client;
        public TestimonialService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7200/api/");
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("Testimonials");
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"Testimonials/{id}");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return null;
                }

                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return null;
                }

                return System.Text.Json.JsonSerializer.Deserialize<UpdateTestimonialDto>(jsonString, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }

            return null;
        }
        public async Task CreateAsync(CreateTestimonialDto createTestimonialDto)
        {
            await _client.PostAsJsonAsync("Testimonials", createTestimonialDto);
        }

        public async Task UpdateAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            await _client.PutAsJsonAsync("Testimonials", updateTestimonialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"Testimonials/{id}");
        }
    }
}
