﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDocumentos.Modelo.Documento
{
   public class CenarioModel
    {
        public int Id { get; set; }
        public string Dependência { get; set; }
        public enum Relevancia {Alta, Media, Baixa }
        public string Descricao { get; set; }
        public string ResultadoEsperado { get; set; }
        public DocumentoModel Documento { get; set; }
    }
}
