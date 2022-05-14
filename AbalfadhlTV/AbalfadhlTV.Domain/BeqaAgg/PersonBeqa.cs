namespace AbalfadhlTV.Domain.BeqaAgg;

public class PersonBeqa
{
    public long Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Father { get; set; }
    public string Mather { get; set; }
    public string BirthDay { get; set; }
    public string DeathDay { get; set; }
    public string Biography { get; set; }
    public long BeqaId { get; set; }
    public Beqa Beqa { get; set; }
}