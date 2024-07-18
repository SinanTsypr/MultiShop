namespace MultiShop.Catalog.API.Dtos.ProductImageDtos
{
    public class CreateProductImageDto
    {
        public string Image1 { get; set; } = null!;
        public string Image2 { get; set; } = null!;
        public string Image3 { get; set; } = null!;
        public string ProductId { get; set; } = null!;
    }
}
