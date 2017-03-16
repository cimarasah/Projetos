using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public PassoModel Passo { get; set; }
    }
}
