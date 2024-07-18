using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.API.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailId { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public string ProductInfo { get; set; } = null!;

        public string ProductId { get; set; } = null!;
        [BsonIgnore]
        public Product Product { get; set; } = null!;
    }
}
