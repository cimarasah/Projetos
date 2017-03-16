using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class UsuarioEquipe
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Equipe Equipe { get; set; }
    }
}
