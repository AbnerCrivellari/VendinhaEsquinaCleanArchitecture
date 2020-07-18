using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendinhaEsquina.Core.Entities;
using VendinhaEsquina.Core.Interfaces;

namespace VendinhaEsquina.Infra.Data.Configs
{
    public class ClienteConfiguration: EntityConfiguration<Cliente>, IEntityTypeConfiguration<Cliente>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            DefaultConfigs(builder, tableName: "Cliente");

            builder.Property(x => x.Nome).HasMaxLength(45).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(45).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(45).IsRequired();

            builder.HasMany(x => x.Pedidos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteID);
        }
    }
}
