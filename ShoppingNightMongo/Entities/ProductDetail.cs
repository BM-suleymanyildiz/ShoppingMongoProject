using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingNightMongo.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        public string ImageUrl { get; set; }

    }
}
