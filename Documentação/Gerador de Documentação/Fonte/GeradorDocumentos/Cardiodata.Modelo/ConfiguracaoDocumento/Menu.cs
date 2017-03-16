using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class Menu
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Produto Produto { get; set; }
    }
}
