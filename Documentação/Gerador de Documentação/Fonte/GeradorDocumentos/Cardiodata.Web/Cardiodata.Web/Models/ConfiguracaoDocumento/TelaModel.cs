using GeradorDocumentos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class TelaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public FuncionalidadeModel Funcionalidade { get; set; }
    }
}
