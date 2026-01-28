using AITech.Business.Services.SocialServices;
using AITech.DTO.SocialDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialsController(ISocialService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.TGetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _service.TGetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialDto dto)
        {
            await _service.TCreateAsync(dto);
            return Ok("Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialDto dto)
        {
            await _service.TUpdateAsync(dto);
            return Ok("Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.TDeleteAsync(id);
            return Ok("Silindi");
        }
    }
}
