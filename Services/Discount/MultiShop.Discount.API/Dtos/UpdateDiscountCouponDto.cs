namespace MultiShop.Discount.API.Dtos
{
    public class UpdateDiscountCouponDto
    {
        public int CouponId { get; set; }
        public string Code { get; set; } = null!;
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
