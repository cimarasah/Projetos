using GeradorDocumentos.Modelo;
using GeradorDocumentos.Web.Models.ConfiguracaoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class FuncionalidadeModel
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public EntregaModel Entrega { get; set; }
        public MenuModel Menu { get; set; }
        public string Objetivo { get; set; }
        

    }
}
