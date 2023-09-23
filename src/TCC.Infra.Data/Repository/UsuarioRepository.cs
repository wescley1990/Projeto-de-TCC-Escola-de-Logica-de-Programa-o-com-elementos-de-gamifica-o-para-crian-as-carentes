using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;
using TCC.Infra.Data.Context;

namespace TCC.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<Usuario> DbSet;
        public IUnitOfWork UnitOfWork => Db;

        public UsuarioRepository(AppDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Usuario>();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await DbSet.ToListAsync();
        }
    }
}
