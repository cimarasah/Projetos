using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cardiodata.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cardiodata.Entity
{
    public class CardiodataContexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapPaciente = modelBuilder.Entity<Paciente>();
            mapPaciente.Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapPaciente.Property(x => x.Nome)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(150);

        }

        public System.Data.Entity.DbSet<Cardiodata.Modelo.Paciente> Pacientes { get; set; }
    }
}
