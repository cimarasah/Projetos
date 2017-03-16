using GeradorDocumentos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class Tela
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Funcionalidade Funcionalidade { get; set; }
    }
}
