using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}
