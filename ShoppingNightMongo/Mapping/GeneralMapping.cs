﻿using AutoMapper;
using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Dtos.CustomerDtos;
using ShoppingNightMongo.Dtos.ProductDetailDtos;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Dtos.SliderDtos;
using ShoppingNightMongo.Entities;

namespace ShoppingNightMongo.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, ResultCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, GetCustomerByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();

            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();

            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetProductDetailByIdDto>().ReverseMap();




        }
    }
}
