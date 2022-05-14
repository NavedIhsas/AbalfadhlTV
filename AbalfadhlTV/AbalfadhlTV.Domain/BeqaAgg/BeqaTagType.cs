namespace AbalfadhlTV.Domain.BeqaAgg;

public class BeqaTagType
{
    public long Id { get; set; }
    public string Tag { get; set; }
    public string Name { get; set; }
    public ICollection<Beqa> Beqas { get; set; }
}