using AITech.Business.Services.FaqServices;
using AITech.DTO.FaqDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqsController(IFaqService _faqService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _faqService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _faqService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFaqDto createDto)
        {
            await _faqService.TCreateAsync(createDto);
            return Ok("Hakkımızda bilgisi eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFaqDto updateDto)
        {
            await _faqService.TUpdateAsync(updateDto);
            return Ok("Hakkımızda bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _faqService.TDeleteAsync(id);
            return Ok("Hakkımızda bilgisi silindi");
        }
    }
}
