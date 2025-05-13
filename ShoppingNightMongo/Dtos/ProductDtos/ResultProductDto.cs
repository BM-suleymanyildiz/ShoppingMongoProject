namespace ShoppingNightMongo.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
    }
}
