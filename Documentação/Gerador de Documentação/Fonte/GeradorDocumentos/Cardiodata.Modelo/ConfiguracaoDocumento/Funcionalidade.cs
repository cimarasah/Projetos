using GeradorDocumentos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class Funcionalidade
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public Entrega Entrega { get; set; }
        public Menu Menu { get; set; }
        public string Objetivo { get; set; }
        

    }
}
