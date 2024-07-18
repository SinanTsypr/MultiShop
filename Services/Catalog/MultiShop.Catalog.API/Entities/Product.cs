using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;

        public string CategoryId { get; set; } = null!;
        [BsonIgnore]
        public Category Category { get; set; } = null!;
    }
}
