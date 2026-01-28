using AITech.Business.Services.AboutServices;
using AITech.DTO.AboutDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var values = await _aboutService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _aboutService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto createDto)
        {
            await _aboutService.TCreateAsync(createDto);
            return Ok("Hakkımızda bilgisi eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto updateDto)
        {
            await _aboutService.TUpdateAsync(updateDto);
            return Ok("Hakkımızda bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutService.TDeleteAsync(id);
            return Ok("Hakkımızda bilgisi silindi");
        }
    }
}
