using AbalfadhlTV.Domain.Attributes;

namespace AbalfadhlTV.Domain.BeqaAgg
{
    [Auditable]
    public class Beqa
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public long? Child { get; set; }
        public bool IsNeabati { get; set; }
        public Beqa ParentBeqa { get; set; }
        public ICollection<Beqa> Beqas { get; set; }
        public ICollection<BeqaTagType> BeqaTagTypes { get; set; }
        public ICollection<Camera> Cameras { get; set; }
        public ICollection<Media> Medias { get; set; }
        public ICollection<PersonBeqa> PersonBeqas { get; set; }
        public ICollection<BeqaCoordinates> BeqaCoordinatesCollection { get; set; }
        public ICollection<BeqaContact> BeqaContacts { get; set; }
    }

    public class BeqaContact
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public long BeqaId { get; set; }
        public Beqa Beqa { get; set; }
       
    }

    public class BeqaTagType
    {
        public long Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public ICollection<Beqa> Beqas { get; set; }
    }

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

    public class BeqaCoordinates
    {
        public long Id { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public long BeqaId { get; set; }
        public Beqa Beqa { get; set; }
    }
}
