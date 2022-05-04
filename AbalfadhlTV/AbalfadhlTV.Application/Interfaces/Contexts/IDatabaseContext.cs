using AbalfadhlTV.Domain.ImamzadehaAgg;
using Microsoft.EntityFrameworkCore;

namespace AbalfadhlTV.Application.Interfaces.Contexts
{
    public interface IDatabaseContext
    {
        DbSet<CountryImamzadeh> CountriesImamzadehs { get; set; }
        DbSet<CitiesImamzadeh> CitiesImamzadehs { get; set; }
        DbSet<ItemsImamzadeh> ItemsImamzadehs { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
