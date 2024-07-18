namespace MultiShop.Catalog.API.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public string CategoryId { get; set; } = null!;
    }
}
