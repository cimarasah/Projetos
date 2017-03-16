using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class PassoModel
    {
        public int Id { get; set; }
        public string ResultadoEsperado { get; set; }
        public CenarioModel Cenario { get; set; }
    }
}
