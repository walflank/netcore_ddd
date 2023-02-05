using CRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD.Infra.Data.Mappings
{
    public class PistaMapping : IEntityTypeConfiguration<Pista>
    {

        public void Configure(EntityTypeBuilder<Pista> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.description).IsRequired();

        }
    }
}
