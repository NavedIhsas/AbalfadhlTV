using AbalfadhlTV.Common.Contracts;

namespace AbalfadhlTV.Application.Dtos.Beqa
{
    public class AddBeqa
    {
      
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public long? Child { get; set; } = null;
    }

    public class EditBeqa : AddBeqa
    {
        public long Id { get; set; }
    }

    public class BeqaSearchModel
    {
        public string Name { get; set; }
    }

    public class GetBeqaList:AddBeqa
    {
        public long Id { get; set; }
        public List<Link> Links { get; set; }
    }


}
