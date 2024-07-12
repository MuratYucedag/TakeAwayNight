namespace TakeAwayNight.Discount.Dtos
{
    public class ResultDiscountCouponDto
    {
        public int DiscountCouponId { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
