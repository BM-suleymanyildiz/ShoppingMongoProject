using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.ProductDetailDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.ProductDetailService
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<ProductDetail> _productDetailCollection;
        private readonly IMongoCollection<Product> _productCollection;



        public ProductDetailService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productDetailCollection = database.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
        {
            var productDetail = _mapper.Map<ProductDetail>(createProductDetailDto);
            await _productDetailCollection.InsertOneAsync(productDetail);
        }

        public async Task DeleteProductDetailAsync(string id)
        {
            await _productDetailCollection.DeleteOneAsync(x => x.ProductDetailId == id);
        }

        public async Task<List<ResultProductDetailDto>> GetAllProductDetailAsync()
        {
            var productDetails = await _productDetailCollection.Find(x => true).ToListAsync();
            var products = await _productCollection.Find(x => true).ToListAsync();

            var result = productDetails.Select(img =>
            {
                var dto = _mapper.Map<ResultProductDetailDto>(img);
                var product = products.FirstOrDefault(p => p.ProductId == img.ProductId);
                dto.ProductName = product?.ProductName;
                return dto;
            }).ToList();

            return result;
        }

        public async Task<GetProductDetailByIdDto> GetProductDetailByIdAsync(string id)
        {
            var productDetail = await _productDetailCollection.Find(x => x.ProductDetailId == id).FirstOrDefaultAsync();
            var dto = _mapper.Map<GetProductDetailByIdDto>(productDetail);

            var product = await _productCollection.Find(x => x.ProductId == productDetail.ProductId).FirstOrDefaultAsync();
            dto.ProductName = product?.ProductName;

            return dto;
        }

        public async Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
        {
            var productDetail = _mapper.Map<ProductDetail>(updateProductDetailDto);
            await _productDetailCollection.FindOneAndReplaceAsync(x => x.ProductDetailId == updateProductDetailDto.ProductDetailId, productDetail);
        }
    }
}
