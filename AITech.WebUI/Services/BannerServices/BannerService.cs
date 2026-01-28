using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;
        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7200/api/");
            _client = client;
        }
        public async Task CreateAsync(CreateBannerDto bannerDto)
        {
            await _client.PostAsJsonAsync("Banners", bannerDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            var Banners = await _client.GetFromJsonAsync<List<ResultBannerDto>>("Banners");
            return Banners;
        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync("Banners/" + id);

            if (response.IsSuccessStatusCode)
            {
                // API "204 No Content" (Başarılı ama boş) dönerse
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return null;
                }

                // İçeriği metin olarak oku ve gerçekten dolu mu bak
                var jsonString = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return null; 
                }

                // 3. Durum: Doluysa güvenle JSON'a çevir
                return System.Text.Json.JsonSerializer.Deserialize<UpdateBannerDto>(jsonString, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }

            return null;
        }

        public async Task UpdateAsync(UpdateBannerDto bannerDto)
        {
            await _client.PutAsJsonAsync("Banners", bannerDto);
        }

        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync("banners/makeActive/" + id, null);
        }

        public async Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync("banners/makePassive/" + id, null);
        }

       
    }
}
