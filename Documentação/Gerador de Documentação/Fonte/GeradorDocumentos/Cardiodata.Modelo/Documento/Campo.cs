using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class Campo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string FormaPreenchimento { get; set; }
        public string Tamanho { get; set; }
        public Documento Documento { get; set; }
    }
}
