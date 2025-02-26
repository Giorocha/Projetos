﻿using System;
using System.Collections.Generic;

namespace Senai.OpFlix.WebApi.Domains
{
    public partial class Lancamentos
    {
        public Lancamentos()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdLancamento { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public int DuracaoMin { get; set; }
        public DateTime DataLancamento { get; set; }
        public int? IdPlataforma { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdClassificao { get; set; }
        public int? IdTipoLancamento { get; set; }
        public string Imagem { get; set; }

        public Categorias IdCategoriaNavigation { get; set; }
        public Classificacoes IdClassificaoNavigation { get; set; }
        public Plataformas IdPlataformaNavigation { get; set; }
        public TipoLancamento IdTipoLancamentoNavigation { get; set; }
        public ICollection<Favoritos> Favoritos { get; set; }
    }
}
