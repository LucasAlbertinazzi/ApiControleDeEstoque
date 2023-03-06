using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblContaEstoquePre
    {
        public int Id { get; set; }
        public int? Iditem { get; set; }
        public int? Idgrupo { get; set; }
        public int? Idcategoria { get; set; }
        public int? Idsubgrupo { get; set; }
        public string Sku { get; set; }
        public string Idlocal { get; set; }
        public string Usuario { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? Datasave { get; set; }
        public int Idlista { get; set; }
        public string? Finaliza { get; set; }
        public Decimal? EstoqueAtual { get; set; }
    }

    public partial class SelectEstoqueAtual
    {
        public int? IdLista { get; set; }

        public Decimal EstoqueAtual { get; set; }
    }
}
