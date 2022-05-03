using Cartao.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cartao.Api.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cartoes> Cartoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cartoes>().HasKey(p => p.Id);
            builder.Entity<Cartoes>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Cartoes>().Property(p => p.TipoCartao).IsRequired().HasMaxLength(50);
            builder.Entity<Cartoes>().Property(p => p.NumeroCartao).IsRequired().HasMaxLength(16);
            builder.Entity<Cartoes>().Property(p => p.IdPessoa).IsRequired();
            builder.Entity<Cartoes>().Property(p => p.StatusCartao).IsRequired();
        }
    }
}
