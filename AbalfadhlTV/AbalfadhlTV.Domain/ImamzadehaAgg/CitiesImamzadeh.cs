using AbalfadhlTV.Domain.Attributes;

namespace AbalfadhlTV.Domain.ImamzadehaAgg;

[Auditable]
public class CitiesImamzadeh
{
    public CitiesImamzadeh(string name, long countryId)
    {
        Name = name;
        CountryId=countryId;
    }
    public long Id { get; private set; }
    public string Name { get; private set; }
    public long CountryId { get;private set; }
    public CountryImamzadeh CountryImamzadeh { get;private set; }
    public ICollection<ItemsImamzadeh> ItemsImamzadeh { get;private set; }

    public void Edit(string name,long countryId)
    {
        Name = name;
        CountryId= countryId;
    }
}