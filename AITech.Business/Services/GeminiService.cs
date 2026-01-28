using AITech.DTO.GeminiDtos;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace AITech.Business.Services
{
    public class GeminiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl;

        public GeminiService(IConfiguration configuration, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiKey = configuration["Gemini:ApiKey"];
            _apiUrl = configuration["Gemini:Url"];
        }

        public async Task<string> GenerateContentAsync(string prompt)
        {
            if (string.IsNullOrEmpty(_apiUrl)) return "Hata: URL yok.";

            var systemInstruction = @"
        Sen 'AI.Tech' adında ileri teknoloji yapay zeka çözümleri sunan kurumsal bir firma için çalışan 
        uzman bir dijital iş asistanısın. 
        Görevin: Kullanıcılara yaratıcı, profesyonel ve sektöre uygun çözümler üretmek.
        
        Kurallar:
        1. Cevapların her zaman Türkçe olsun.
        2. Hitabetin profesyonel ama samimi olsun.
        3. Cevabı Markdown formatında ver (Başlıklar için **kalın**, maddeler için * kullan).
        4. Çok uzun paragraflar yazma, okunabilir ve net olsun.
        5. Eğer kullanıcı slogan isterse, kısa ve vurucu 3-5 tane seçenek sun.
        
        Kullanıcının İsteği Şudur: ";

            var fullPrompt = systemInstruction + prompt;

            var requestBody = new GeminiRequest
            {
                contents = new List<Content>
        {
            new Content
            {
                parts = new List<Part> { new Part { text = fullPrompt } }
            }
        }
            };

            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_apiUrl}?key={_apiKey}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(responseString);
                return geminiResponse?.candidates?.FirstOrDefault()?.content?.parts?.FirstOrDefault()?.text
                       ?? "Cevap üretilemedi.";
            }

            return "Hata oluştu.";
        }
    }
}
