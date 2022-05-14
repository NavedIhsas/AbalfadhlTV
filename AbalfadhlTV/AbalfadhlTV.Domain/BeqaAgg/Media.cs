namespace AbalfadhlTV.Domain.BeqaAgg;

public class Media
{
    public long Id { get; set; }
    public string ContentType { get; set; }
    public string DigestTag { get; set; }
    public string Order { get; set; }
    public string About { get; set; }
    public long BeqaId { get; set; }
    public Beqa Beqa { get; set; }
    public ICollection<MediaFormat> MediaFormats { get; set; }

}