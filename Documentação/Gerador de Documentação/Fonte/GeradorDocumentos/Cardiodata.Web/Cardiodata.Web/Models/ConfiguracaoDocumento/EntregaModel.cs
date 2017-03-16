using GeradorDocumentos.Modelo;
using GeradorDocumentos.Modelo.ConfiguracaoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Web.Models.ConfiguracaoDocumento
{
    public class EntregaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ProjetoModel Projeto { get; set; }
    }
}
