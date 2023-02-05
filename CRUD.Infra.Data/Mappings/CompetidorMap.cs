using CRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD.Infra.Data.Mappings
{
    public class CompetidorMapping : IEntityTypeConfiguration<Competidor>
    {

        public void Configure(EntityTypeBuilder<Competidor> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired();
            builder.Property(x => x.sexo).IsRequired().HasColumnType("char(1)");
            builder.Property(x => x.temperatura).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.peso).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.altura).IsRequired().HasColumnType("decimal");

            builder.HasOne(x => x.race)
                .WithMany(x => x.competidor_)
                .HasForeignKey(x => x.competidor_id)
                .HasConstraintName("FK_Competidor_Race");

        }
    }
}
