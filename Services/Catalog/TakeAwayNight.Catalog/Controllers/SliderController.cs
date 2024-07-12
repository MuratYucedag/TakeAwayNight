using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Catalog.Dtos.SliderDtos;
using TakeAwayNight.Catalog.Services.SliderServices;

namespace TakeAwayNight.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _SliderService;
        public SliderController(ISliderService SliderService)
        {
            _SliderService = SliderService;
        }

        [HttpGet]
        public async Task<IActionResult> SliderList()
        {
            var values = await _SliderService.GetAllSliderAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _SliderService.CreateSliderAsync(createSliderDto);
            return Ok("Slider başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _SliderService.DeleteSliderAsync(id);
            return Ok("Slider başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _SliderService.UpdateSliderAsync(updateSliderDto);
            return Ok("Slider başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlider(string id)
        {
            var value = await _SliderService.GetByIdSliderAsync(id);
            return Ok(value);
        }
    }
}
