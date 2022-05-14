namespace AbalfadhlTV.Domain.BeqaAgg;

public class BeqaContact
{
    public long Id { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }
    public string Mobile { get; set; }
    public long BeqaId { get; set; }
    public Beqa Beqa { get; set; }
       
}