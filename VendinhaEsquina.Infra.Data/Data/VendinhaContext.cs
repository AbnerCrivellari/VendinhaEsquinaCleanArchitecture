using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VendinhaEsquina.Core.Entities;
using VendinhaEsquina.Core.Interfaces;

namespace VendinhaEsquina.Infra.Data.Data
{
    public class VendinhaContext : DbContext
    {
        public VendinhaContext(DbContextOptions<VendinhaContext> options)
        : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(IEntityConfig).IsAssignableFrom(x) && !x.IsAbstract).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
    }
}
