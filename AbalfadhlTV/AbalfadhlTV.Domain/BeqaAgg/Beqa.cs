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
        public long? ParentId { get; set; }
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
}
