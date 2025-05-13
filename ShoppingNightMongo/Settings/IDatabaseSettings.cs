namespace ShoppingNightMongo.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CategoryCollactionName { get; set; }
        public string ProductCollactionName { get; set; }
    }
}
