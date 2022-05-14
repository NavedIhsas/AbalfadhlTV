namespace AbalfadhlTV.Domain.BeqaAgg;

public class BeqaCoordinates
{
    public long Id { get; set; }
    public string Lat { get; set; }
    public string Lon { get; set; }
    public long BeqaId { get; set; }
    public Beqa Beqa { get; set; }
}