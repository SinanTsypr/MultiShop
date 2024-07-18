using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.API.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //Id'nin benzersin olduğunu uygulamaya bildirdik
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
