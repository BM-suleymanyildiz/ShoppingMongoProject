namespace ShoppingNightMongo.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();

    }
}
