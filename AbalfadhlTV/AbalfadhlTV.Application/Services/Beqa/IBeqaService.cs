using AbalfadhlTV.Application.Dtos;
using AbalfadhlTV.Application.Dtos.Beqa;
using AbalfadhlTV.Application.Services.Contexts;
using AbalfadhlTV.Common;
using AbalfadhlTV.Common.Contracts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AbalfadhlTV.Application.Services.Beqa
{
    public interface IBeqaService
    {
        BaseDto<AddBeqa> Add(AddBeqa command);
        BaseDto Remove(long id);
        BaseDto<EditBeqa> Edit(EditBeqa command);
        BaseDto<GetBeqaList> FindById(long id);
        PaginatedItemsDto<GetBeqaList> GetList(int page, int pageSize);
        BaseDto<AddBeqa> AddCollection(List<AddBeqa> command);
        BaseDto RemoveCollection(List<long> id);
    }

    public class BeqaService : IBeqaService
    {

        private readonly IDatabaseContext _context;
        private readonly IMapper _mapper;
        private bool Smoke;
        public BeqaService(IDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        /// <summary>
        /// live mode settings
        /// </summary>
        public void Live_Mode()
        {
            if (Sade() == true)
            {
                Smoke = false; 
                Happy.Start();
            }

            if (Love() != Coding) // coding is true love
            {
                Coffee();
                Sleep();
                StartCoding(); // come back again
            }

            
        }

        private void StartCoding()
        {
            throw new NotImplementedException();
        }

        private void TryAgain()
        {
            throw new NotImplementedException();
        }

        private static void Sleep()
        {
            throw new NotImplementedException();
        }

        private static void Coffee()
        {
            throw new NotImplementedException();
        }

        public bool Coding { get; set; }

        private bool Love()
        {
            throw new NotImplementedException();
        }

        private bool Sade()
        {
            throw new NotImplementedException();
        }


        public BaseDto<AddBeqa> Add(AddBeqa command)
        {
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            Live_Mode();
            var model = _mapper.Map<Domain.BeqaAgg.Beqa>(command);
            _context.Beqas.Add(model);
            _context.SaveChanges();
            return new BaseDto<AddBeqa>
            (
                true,
                new List<string> { "عملیات با موفقیت انجام شد" },
                _mapper.Map<AddBeqa>(model)
            );
        }
        public BaseDto<AddBeqa> AddCollection(List<AddBeqa> command)
        {
            if (command!=null && command.Any())
            {
                var model = new Domain.BeqaAgg.Beqa();
                foreach (var list in command)
                {
                    model = _mapper.Map<Domain.BeqaAgg.Beqa>(list);
                    _context.Beqas.Add(model);
                    _context.SaveChanges();
                }
                return new BaseDto<AddBeqa>
                (
                    true,
                    new List<string> { $"عملیات با موفقیت انجام شد" },
                    _mapper.Map<AddBeqa>(model)
                );
            }
            return new BaseDto<AddBeqa>
            (
                false
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
         public BaseDto RemoveCollection(List<long> id)
         {
             if (!id.Any())
                 return new BaseDto
                     (false);

            foreach (var beqa in id.Select(removeId => _context.Beqas.Find(removeId)))
            {
                if (beqa != null) _context.Beqas.Remove(beqa);
                _context.SaveChanges();
            }

            return new BaseDto
            (
                true,
                new List<string> { $"ایتم با موفقیت حذف شد" }
            );

        }

        public BaseDto<EditBeqa> Edit(EditBeqa command)
        {
            var model = _context.Beqas.SingleOrDefault(p => p.Id == command.Id);
            ((IMapperBase)_mapper).Map<EditBeqa, Domain.BeqaAgg.Beqa>(command, model);
            _context.SaveChanges();
            return new BaseDto<EditBeqa>
            (
                true,
                new List<string> { $" {model.Name} با موفقیت ویرایش شد" },

                _mapper.Map<EditBeqa>(model)
            );
        }

        public BaseDto<GetBeqaList> FindById(long id)
        {
            var data = _context.Beqas.Find(id);

            var result = _mapper.Map<GetBeqaList>(data);
            return new BaseDto<GetBeqaList>(true, new List<string>(), result);
        }

        public PaginatedItemsDto<GetBeqaList> GetList(int page, int pageSize)
        {
            int totalCount = 0;
            var model = _context.Beqas.Where(x => x.ParentId == null)
                .PagedResult<Domain.BeqaAgg.Beqa>(page, pageSize, out totalCount);
            var result = _mapper.ProjectTo<GetBeqaList>(model).AsNoTracking().ToList();
            return new PaginatedItemsDto<GetBeqaList>(page, pageSize, totalCount, result);
        }
    }

    public class Happy
    {
        public static void Start()
        {
            

        }
    }
}
