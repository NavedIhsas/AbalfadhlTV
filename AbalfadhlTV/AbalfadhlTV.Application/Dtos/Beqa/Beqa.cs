using AbalfadhlTV.Common.Contracts;

namespace AbalfadhlTV.Application.Dtos.Beqa
{
    public class AddBeqa
    {
      
        public long Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class EditBeqa : AddBeqa
    {
    }

    public class BeqaSearchModel
    {
        public string Name { get; set; }
    }

    public class GetBeqaList:AddBeqa
    {
      
        public List<Link> Links { get; set; }
    }


}
