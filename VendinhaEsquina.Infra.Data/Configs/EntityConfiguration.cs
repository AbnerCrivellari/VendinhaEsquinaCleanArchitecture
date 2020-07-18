using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendinhaEsquina.Core.Entities;

namespace VendinhaEsquina.Infra.Data.Configs
{
    public class EntityConfiguration<TEntity> where TEntity : BaseEntity
    {
        public void DefaultConfigs(EntityTypeBuilder<TEntity> builder, string tableName)
        {
            builder.ToTable(tableName);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CriadoEm).IsRequired();
        }
    }
}
