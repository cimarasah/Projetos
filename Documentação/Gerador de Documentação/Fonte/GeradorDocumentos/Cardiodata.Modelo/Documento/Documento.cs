using GeradorDocumentos.Modelo.ConfiguracaoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class Documento
    {
        public int Id { get; set; }
        public enum Tipo { PlanoTeste, Evidencia } 
        public Funcionalidade Funcionalidade { get; set; }
    }
}
