using AbalfadhlTV.Application.Dtos;
using AbalfadhlTV.Application.Interfaces.Contexts;
using AbalfadhlTV.Common;
using AbalfadhlTV.Common.Contracts;
using AbalfadhlTV.Domain.ImamzadehaAgg;
using AutoMapper;

namespace AbalfadhlTV.Application.Interfaces.Imamzadeha
{
    public interface ICountryImamzadehServices
    {
        BaseDto<CountryImamzadehDto> Add(CountryImamzadehDto catalogType);
        BaseDto Remove(long id);
        BaseDto<CountryImamzadehDto> Edit(CountryImamzadehDto catalogType);
        BaseDto<CountryImamzadehDto> FindById(long id);
        PaginatedItemsDto<CountryImamzadehListDto> GetList(int page, int pageSize);
    }

    public class CountryImamzadehServices: ICountryImamzadehServices
    {

        private readonly IDatabaseContext _context;
        private readonly IMapper _mapper;
        public CountryImamzadehServices(IDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public BaseDto<CountryImamzadehDto> Add(CountryImamzadehDto catalogType)
        {
            var model = _mapper.Map<CountryImamzadeh>(catalogType);
            _context.CountriesImamzadehs.Add(model);
            _context.SaveChanges();
            return new BaseDto<CountryImamzadehDto>
            (
                true,
                new List<string> { $"کشور {model.Name}  با موفقیت در سیستم ثبت شد" },
                _mapper.Map<CountryImamzadehDto>(model)
            );
        }

        public BaseDto Remove(long id)
        {
            var catalogType = _context.CountriesImamzadehs.Find(id);
            if (catalogType != null) _context.CountriesImamzadehs.Remove(catalogType);
            _context.SaveChanges();
            return new BaseDto
            (
                true,
                new List<string> { $"ایتم با موفقیت حذف شد" }
            );
        }

        public BaseDto<CountryImamzadehDto> Edit(CountryImamzadehDto catalogType)
        {
            var model = _context.CountriesImamzadehs.SingleOrDefault(p => p.Id == catalogType.Id);
            _mapper.Map(catalogType, model);
            _context.SaveChanges();
            return new BaseDto<CountryImamzadehDto>
            (
                true,
                new List<string> { $"کشور {model.Name} با موفقیت ویرایش شد" },

                _mapper.Map<CountryImamzadehDto>(model)
            );
        }

        public BaseDto<CountryImamzadehDto> FindById(long id)
        {
            var data = _context.CountriesImamzadehs.Find(id);
            var result = _mapper.Map<CountryImamzadehDto>(data);
            return new BaseDto<CountryImamzadehDto>( result);
        }

        public PaginatedItemsDto<CountryImamzadehListDto> GetList(int page, int pageSize)
        {
            int totalCount = 0;
            var model = _context.CountriesImamzadehs
                .PagedResult(page, pageSize, out totalCount);
            var result = _mapper.ProjectTo<CountryImamzadehListDto>(model).ToList();

            

            return new PaginatedItemsDto<CountryImamzadehListDto>(page, pageSize, totalCount, result);
        }
    }



    public class CountryImamzadehDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class CountryImamzadehListDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Link> Links { get; set; }
    }
}
