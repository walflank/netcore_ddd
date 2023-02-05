using CRUD.Domain.Entities;
using CRUD.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infra.Data.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       
        public DbSet<Competidor> Competidor { get; set; }
        public DbSet<Race> Race { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {
           
            builder.Entity<Competidor>(new CompetidorMapping().Configure);
            builder.Entity<Race>(new RaceMapping().Configure);
            base.OnModelCreating(builder);
        }
       
        
    }
}
