using prueba.Models;
using Microsoft.EntityFrameworkCore;

namespace prueba.Data
{
    public class PruebaDbContext :DbContext
    {
        public PruebaDbContext(DbContextOptions<PruebaDbContext> options) : base(options)
        {
        }
        
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Vet> Vets { get; set; }
    }
}