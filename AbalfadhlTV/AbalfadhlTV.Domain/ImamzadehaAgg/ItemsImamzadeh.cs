using AbalfadhlTV.Domain.Attributes;

namespace AbalfadhlTV.Domain.ImamzadehaAgg;

[Auditable]
public class ItemsImamzadeh
{
    public ItemsImamzadeh(string name,long cityId)
    {
        Name = name;
        CityId = cityId;
    }
    public long Id { get; private set; }
    public string Name { get; private set; }
    public long CityId { get;private set; }
    public CitiesImamzadeh CitiesImamzadeh { get;private set; }
    public void Edit(string name,long cityId)
    {
        Name = name;
        CityId = cityId;
    }
}