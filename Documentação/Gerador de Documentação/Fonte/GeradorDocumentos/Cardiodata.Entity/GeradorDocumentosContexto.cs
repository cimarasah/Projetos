using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GeradorDocumentos.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using GeradorDocumentos.Modelo.ConfiguracaoDocumento;

namespace GeradorDocumentos.Entity
{
    public class GeradorDocumentosContexto : DbContext
    {
        public GeradorDocumentosContexto() : base("name=GeradorDocumentosContexto")

        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapProjeto = modelBuilder.Entity<Projeto>();
            mapProjeto.Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapProjeto.Property(x => x.Descricao)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(50);
            mapProjeto.Property(x => x.Resumo)
                .IsVariableLength()
                .HasMaxLength(400);

        }

        public System.Data.Entity.DbSet<GeradorDocumentos.Modelo.ConfiguracaoDocumento.Projeto> Projetos { get; set; }
    }
}
