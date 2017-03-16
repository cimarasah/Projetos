using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.ConfiguracaoDocumento
{
    public class ProjetoModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Resumo")]
        public string Resumo { get; set; }
    }
}
