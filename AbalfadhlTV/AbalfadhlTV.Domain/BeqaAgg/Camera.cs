namespace AbalfadhlTV.Domain.BeqaAgg;

public class Camera
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public bool IsZerih { get; set; }
    public long BeqaId { get; set; }
    public bool IsZiaratOnline { get; set; }
    public Beqa Beqa { get; set; }
}