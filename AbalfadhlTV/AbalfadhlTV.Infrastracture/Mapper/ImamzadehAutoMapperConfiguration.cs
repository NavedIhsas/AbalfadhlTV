using AbalfadhlTV.Application.Interfaces.Imamzadeha;
using AutoMapper;
using CountryImamzadeh = AbalfadhlTV.Domain.ImamzadehaAgg.CountryImamzadeh;

namespace AbalfadhlTV.infrastructure.Mapper
{
    public class ImamzadehAutoMapperConfiguration:Profile
    {
        public ImamzadehAutoMapperConfiguration()
        {
            CreateMap<CountryImamzadeh, CountryImamzadehDto>().ReverseMap();
            CreateMap<CountryImamzadeh, CountryImamzadehListDto>();

            //CreateMap<CatalogType, MenuItemDto>()
            //    .ForMember(dest => dest.Name, opt =>
            //        opt.MapFrom(src => src.Type))
            //    .ForMember(dest => dest.ParentId, opt =>
            //        opt.MapFrom(src => src.ParentCatalogTypeId))
            //    .ForMember(dest => dest.SubMenu, opt =>
            //        opt.MapFrom(src => src.SubType));
        }
    }
}
