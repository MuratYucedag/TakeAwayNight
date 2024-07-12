namespace TakeAwayNight.Discount.Dtos
{
    public class GetByIdDiscountCouponDto
    {
        public int DiscountCouponId { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
