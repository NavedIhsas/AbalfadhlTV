using AbalfadhlTV.Application.Dtos.Beqa;
using AbalfadhlTV.Domain.BeqaAgg;
using AutoMapper;

namespace AbalfadhlTV.infrastructure.Mapper
{
    public class BeqaAutoMapperConfiguration:Profile
    {
        public BeqaAutoMapperConfiguration()
        {
            CreateMap<Beqa, AddBeqa>().ReverseMap();
            CreateMap<Beqa, EditBeqa>();

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
