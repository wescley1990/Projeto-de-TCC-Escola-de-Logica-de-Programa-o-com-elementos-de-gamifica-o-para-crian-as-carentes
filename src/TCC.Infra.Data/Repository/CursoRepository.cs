using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using TCC.Domain.Enums;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;
using TCC.Infra.Data.Context;

namespace TCC.Infra.Data.Repository;

public class CursoRepository : ICursoRepository
{
    protected readonly AppDbContext Db;
    protected readonly DbSet<Curso> DbSet;
    public IUnitOfWork UnitOfWork => Db;
    public CursoRepository(AppDbContext context)
    {
        Db = context;
        DbSet = Db.Set<Curso>();
    }
    
    public async Task<Curso> GetById(Guid id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<Curso>> GetAll()
    {
        return new List<Curso>
        {
            new Curso(Guid.NewGuid(), "Teste1", "Curso teste 1", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste2", "Curso teste 2", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste3", "Curso teste 3", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste4", "Curso teste 4", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste5", "Curso teste 5", Nivel.Iniciante),
        };
        //return await DbSet.ToListAsync();
    }
    
    public void Add(Curso curso)
    {
        DbSet.Add(curso);
    }

    public void Update(Curso curso)
    {
        DbSet.Update(curso);
    }

    public void Remove(Curso curso)
    {
        DbSet.Remove(curso);
    }

    public void Dispose()
    {
        Db.Dispose();
    }
}