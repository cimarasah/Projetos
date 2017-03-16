using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class UsuarioEquipeModel
    {
        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public EquipeModel Equipe { get; set; }
    }
}
