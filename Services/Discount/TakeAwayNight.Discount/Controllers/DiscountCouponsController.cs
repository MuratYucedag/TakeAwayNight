using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Discount.Dtos;
using TakeAwayNight.Discount.Services;

namespace TakeAwayNight.Discount.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiscountCouponsController : ControllerBase
	{
		private readonly IDiscountCouponService _discountCouponService;
		public DiscountCouponsController(IDiscountCouponService discountCouponService)
		{
			_discountCouponService = discountCouponService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllDiscountCoupon()
		{
			var values = await _discountCouponService.GetResultDiscountCouponAsync();
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult> CreateDiscountCopun(CreateDiscountCouponDto createDiscountCouponDto)
		{
			await _discountCouponService.CreateDiscountCouponAsync(createDiscountCouponDto);
			return Ok("Kupon oluşturuldu");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteDiscountCoupon(int id)
		{
			await _discountCouponService.DeleteDiscountCouponAsync(id);
			return Ok("Kupon silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
		{
			await _discountCouponService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
			return Ok("Kupon güncellendi");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetDiscountCoupon(int id)
		{
			var value = await _discountCouponService.GetByIdDiscountCouponAsync(id);
			return Ok(value);
		}
	}
}
