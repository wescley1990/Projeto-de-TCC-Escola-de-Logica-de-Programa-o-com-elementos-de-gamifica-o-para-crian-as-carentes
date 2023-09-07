using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using TCC.Domain.Models;
using TCC.Infra.Data.Mappings;

namespace TCC.Infra.Data.Context;

public class AppDbContext : DbContext, IUnitOfWork
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        ChangeTracker.AutoDetectChangesEnabled = false;
    }
    
    public DbSet<Curso> Cursos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Ignore<ValidationResult>();
        foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                     e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            property.SetColumnType("varchar(100)");

        modelBuilder.ApplyConfiguration(new CursoMap());
                
        base.OnModelCreating(modelBuilder);
    }
    
    public async Task<bool> Commit()
    {
        // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
        // performed through the DbContext will be committed
        var success = await SaveChangesAsync() > 0;
        return success;
    }
}