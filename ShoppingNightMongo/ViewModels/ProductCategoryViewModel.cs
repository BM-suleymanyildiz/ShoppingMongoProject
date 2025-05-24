using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Dtos.ProductDtos;
using System.Collections.Generic;
namespace ShoppingNightMongo.ViewModels
{
    public class ProductCategoryViewModel
    {
        public List<ResultProductDto> Products { get; set; }
        public List<ResultCategoryDto> Categories { get; set; }
    }
}
