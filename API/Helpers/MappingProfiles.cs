using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Products, ProductToReturnDto>()
            .ForMember(d => d.ProductBrand, o =>o.MapFrom(s =>s.ProductBrand.BrandName))
            .ForMember(d => d.ProductType, o =>o.MapFrom(s =>s.ProductType.ProductTypeName))
            .ForMember(d => d.PictureURL, o => o.MapFrom<ProductUrlResolver>());  
        }
    }
}