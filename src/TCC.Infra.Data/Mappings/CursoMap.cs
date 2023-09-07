using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.Domain.Models;

namespace TCC.Infra.Data.Mappings;

public class CursoMap : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        throw new NotImplementedException();
    }
}