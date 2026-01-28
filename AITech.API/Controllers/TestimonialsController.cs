using AITech.Business.Services.TestimonialServices;
using AITech.WebUI.DTOs.TestimonialDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(ITestimonialService _testimonialService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _testimonialService.TGetAllAsync();

            // 200 OK koduyla birlikte veriyi JSON formatında dönüyoruz.
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _testimonialService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto createDto)
        {
            await _testimonialService.TCreateAsync(createDto);

            // İşlem başarılıysa kullanıcıya sadece "Tamam" diyoruz.
            return Ok("Referans başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialDto updateDto)
        {
            await _testimonialService.TUpdateAsync(updateDto);
            return Ok("Referans başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testimonialService.TDeleteAsync(id);
            return Ok("Referans başarıyla silindi.");
        }
    }
}
