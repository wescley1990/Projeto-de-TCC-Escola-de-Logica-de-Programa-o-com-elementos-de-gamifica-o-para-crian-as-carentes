using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.Domain.Models;

namespace TCC.Infra.Data.Mappings;

public class ItemLojaMap : IEntityTypeConfiguration<ItemLoja>
{
    public void Configure(EntityTypeBuilder<ItemLoja> builder)
    {
        builder.Property(c => c.Id)
            .HasColumnName("Id");
        
        builder.Property(c => c.Nome)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.ImagemUrl)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsRequired();
    }
}