using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class Evento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Passo Passo { get; set; }
    }
}
