﻿using GeradorDocumentos.Modelo.ConfiguracaoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
    public class ControleVersaoModel
    {
        public int Id { get; set; }
        public string Versao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public UsuarioEquipeModel UsuarioEquipe { get; set; }
    }
}
