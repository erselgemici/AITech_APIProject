using AITech.Business.Services.FeatureServices;
using AITech.DTO.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IFeatureService _featureService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _featureService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _featureService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto createDto)
        {
            await _featureService.TCreateAsync(createDto);
            return Ok("Hakkımızda bilgisi eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto updateDto)
        {
            await _featureService.TUpdateAsync(updateDto);
            return Ok("Hakkımızda bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _featureService.TDeleteAsync(id);
            return Ok("Hakkımızda bilgisi silindi");
        }
    }
}
