using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingNightMongo.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderSubTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
