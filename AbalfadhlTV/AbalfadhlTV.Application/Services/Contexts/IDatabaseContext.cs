using AbalfadhlTV.Domain.BeqaAgg;
using AbalfadhlTV.Domain.ImamzadehaAgg;
using Microsoft.EntityFrameworkCore;

namespace AbalfadhlTV.Application.Services.Contexts
{
    public interface IDatabaseContext
    {
       DbSet<Domain.BeqaAgg.Beqa> Beqas { get; set; }
       DbSet<PersonBeqa> PersonBeqas { get; set; }
       DbSet<BeqaContact> BeqaContacts { get; set; }
       DbSet<BeqaTagType> BeqaTagTypes { get; set; }
       DbSet<BeqaCoordinates> BeqaCoordinates { get; set; }
       DbSet<Media> Medias { get; set; }
       DbSet<MediaFormat> MediaFormats { get; set; }
       DbSet<Camera> Cameras { get; set; }

        DbSet<CountryImamzadeh> CountriesImamzadehs { get; set; }
        DbSet<CitiesImamzadeh> CitiesImamzadehs { get; set; }
        DbSet<ItemsImamzadeh> ItemsImamzadehs { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
