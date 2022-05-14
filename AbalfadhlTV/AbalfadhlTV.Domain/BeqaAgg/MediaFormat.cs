namespace AbalfadhlTV.Domain.BeqaAgg;

public class MediaFormat
{
    public long Id { get; set; }
    public string FormatType { get; set; }
    public string Link { get; set; }
    public int Resolution { get; set; }
    public string Order { get; set; }
    public long MediaId { get; set; }
    public Media Media { get; set; }
}