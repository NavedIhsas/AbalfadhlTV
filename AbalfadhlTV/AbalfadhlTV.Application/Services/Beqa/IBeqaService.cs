using AbalfadhlTV.Application.Dtos;
using AbalfadhlTV.Application.Dtos.Beqa;
using AbalfadhlTV.Application.Services.Contexts;
using AbalfadhlTV.Common;
using AbalfadhlTV.Common.Contracts;
using AutoMapper;

namespace AbalfadhlTV.Application.Services.Beqa
{
    public interface IBeqaService
    {
        BaseDto<AddBeqa> Add(AddBeqa command);
        BaseDto Remove(long id);
        BaseDto<EditBeqa> Edit(EditBeqa command);
        BaseDto<GetBeqaList> FindById(long id);
        PaginatedItemsDto<GetBeqaList> GetList(int page, int pageSize);
    }

    public class BeqaService: IBeqaService
    {

        private readonly IDatabaseContext _context;
        private readonly IMapper _mapper;
        public BeqaService(IDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public BaseDto<AddBeqa> Add(AddBeqa command)
        {
            var model = _mapper.Map<Domain.BeqaAgg.Beqa>(command);
            _context.Beqas.Add(model);
            _context.SaveChanges();
            return new BaseDto<AddBeqa>
            (
                true,
                new List<string> { $"کشور {model.Name}  با موفقیت در سیستم ثبت شد" },
                _mapper.Map<AddBeqa>(model)
            );
        }

        public BaseDto Remove(long id)
        {
            var beqa = _context.Beqas.Find(id);
            if (beqa != null) _context.Beqas.Remove(beqa);
            _context.SaveChanges();
            return new BaseDto
            (
                true,
                new List<string> { $"ایتم با موفقیت حذف شد" }
            );
        }

        public BaseDto<EditBeqa> Edit(EditBeqa command)
        {
            var model = _context.Beqas.SingleOrDefault(p => p.Id == command.Id);
            ((IMapperBase) _mapper).Map<EditBeqa, Domain.BeqaAgg.Beqa>(command, model);
            _context.SaveChanges();
            return new BaseDto<EditBeqa>
            (
                true,
                new List<string> { $"کشور {model.Name} با موفقیت ویرایش شد" },

                _mapper.Map<EditBeqa>(model)
            );
        }

        public BaseDto<GetBeqaList> FindById(long id)
        {
            var data = _context.Beqas.Find(id);
            var result = _mapper.Map<GetBeqaList>(data);
            return new BaseDto<GetBeqaList>( result);
        }

        public PaginatedItemsDto<GetBeqaList> GetList(int page, int pageSize)
        {
            int totalCount = 0;
            var model = _context.Beqas
                .PagedResult<Domain.BeqaAgg.Beqa>(page, pageSize, out totalCount);
            var result = _mapper.ProjectTo<GetBeqaList>(model).ToList();
            return new PaginatedItemsDto<GetBeqaList>(page, pageSize, totalCount, result);
        }
    }


   
}
