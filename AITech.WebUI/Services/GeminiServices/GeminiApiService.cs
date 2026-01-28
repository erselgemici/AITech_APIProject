using AITech.WebUI.DTOs.GeminiDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WebUI.Services.GeminiServices
{
    public class GeminiApiService
    {
        private readonly HttpClient _httpClient;

        public GeminiApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetGeminiResponseAsync(string prompt)
        {
            var jsonContent = JsonConvert.SerializeObject(new { Prompt = prompt });
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var apiUrl = "https://localhost:7200/api/Gemini";

            try
            {
                var response = await _httpClient.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(jsonString);
                    return result.answer;
                }

                var errorBody = await response.Content.ReadAsStringAsync();
                return $"Bağlantı Hatası! API Adresi: {apiUrl} - Kod: {response.StatusCode} - Mesaj: {errorBody}";
            }
            catch (Exception ex)
            {
                return $"Kritik Hata: API'ye ulaşılamadı. {ex.Message}";
            }
        }
    }
}
