using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuTeste.Models;

namespace MeuTeste.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Viagem>()
                .HasOne(p => p.Cliente)
                .WithMany(b => b.viagens);
        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Viagem> viagens { get; set; }
    }
}
