using AutoMapper;
using ShopApi.Entities.DataTransferObjects;
using ShopApi.Entities.Models;

namespace ShopApi.Web.Api;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
    }
}