using AbalfadhlTV.Domain.Attributes;

namespace AbalfadhlTV.Domain.ImamzadehaAgg
{
    [Auditable]
    public class CountryImamzadeh
    {
        public CountryImamzadeh(string name)
        {
            Name=name;
        }


        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<CitiesImamzadeh> CitiesImamzadeh { get; set; }


        public void Edit(string name)
        {
            Name = name;
        }
    }
}
