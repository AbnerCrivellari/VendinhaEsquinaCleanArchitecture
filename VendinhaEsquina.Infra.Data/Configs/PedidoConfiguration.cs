using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendinhaEsquina.Core.Entities;
using VendinhaEsquina.Core.Interfaces;

namespace VendinhaEsquina.Infra.Data.Configs
{
    public class PedidoConfiguration : EntityConfiguration<Pedido>, IEntityTypeConfiguration<Pedido>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            DefaultConfigs(builder, tableName: "Pedido");

            builder.Property(x => x.ValorTotal).HasColumnType("decimal(5,2)").IsRequired();
        }
    }
}
