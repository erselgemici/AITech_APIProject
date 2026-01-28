using AITech.Business.Services.ChooseServices;
using AITech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoosesController(IChooseService _chooseService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _chooseService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _chooseService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto createDto)
        {
            await _chooseService.TCreateAsync(createDto);
            return Ok("Hakkımızda bilgisi eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseDto updateDto)
        {
            await _chooseService.TUpdateAsync(updateDto);
            return Ok("Hakkımızda bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _chooseService.TDeleteAsync(id);
            return Ok("Hakkımızda bilgisi silindi");
        }
    }
}
