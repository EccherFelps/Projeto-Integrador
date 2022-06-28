using JovemProgramador.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Data.Mapeamento
{
    public class EventoMapeamento : IEntityTypeConfiguration<EventoModel>
    {
        public void Configure(EntityTypeBuilder<EventoModel> builder)
        {
            builder.ToTable("Eventos");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Sobre).HasColumnType("varchar(200)");
            builder.Property(t => t.Rua).HasColumnType("varchar(50)");
            builder.Property(t => t.Bairro).HasColumnType("varchar(50)");
            builder.Property(t => t.Cidade).HasColumnType("varchar(50)");
            builder.Property(t => t.Contato).HasColumnType("varchar(50)");
            builder.Property(t => t.Data).HasColumnType("datetime");
            builder.Property(t => t.Capacidade).HasColumnType("varchar(10)");
        }

    }

  

}
