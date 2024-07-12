using TakeAwayNight.Discount.Dtos;

namespace TakeAwayNight.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<List<ResultDiscountCouponDto>> GetResultDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
    }
}
