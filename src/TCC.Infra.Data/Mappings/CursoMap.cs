using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.Domain.Models;

namespace TCC.Infra.Data.Mappings;

public class CursoMap : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.Property(c => c.Id)
            .HasColumnName("Id");
        
        builder.Property(c => c.Nome)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsRequired();
    }
}