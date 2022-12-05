using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro.Data.Map;
using SistemaDeCadastro.Models;

namespace SistemaDeCadastro.Data
{
    public class Contexto : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        //public Contexto(DbContextOptions<Contexto> options) : base(options) {  }
        public Contexto(DbContextOptions options) : base(options) { }

        public Contexto()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("minhadatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
