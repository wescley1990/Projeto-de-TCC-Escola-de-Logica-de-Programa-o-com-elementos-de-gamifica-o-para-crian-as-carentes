using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;
using TCC.Infra.Data.Context;

namespace TCC.Infra.Data.Repository;

public class ItemLojaRepository : IItemLojaRepository
{
    protected readonly AppDbContext Db;
    protected readonly DbSet<ItemLoja> DbSet;
    public IUnitOfWork UnitOfWork => Db;
    
    public ItemLojaRepository(AppDbContext context)
    {
        Db = context;
        DbSet = Db.Set<ItemLoja>();
    }
    
    public async Task<ItemLoja> GetById(Guid id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<ItemLoja>> GetAll()
    {
        return await DbSet.ToListAsync();
    }

    public void Add(ItemLoja item)
    {
        DbSet.Add(item);
    }

    public void Update(ItemLoja item)
    {
        DbSet.Update(item);
    }

    public void Remove(ItemLoja item)
    {
        DbSet.Remove(item);
    }
    
    public void Dispose()
    {
        Db.Dispose();
    }
}