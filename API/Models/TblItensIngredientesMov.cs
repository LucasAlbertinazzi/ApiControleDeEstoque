using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensIngredientesMov
    {
        public long IdIngredientesMov { get; set; }
        public int IdIngrediente { get; set; }
        public long IdItensMov { get; set; }
        public string Sku { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public string Unidade { get; set; }
        public decimal Qtd { get; set; }
        public bool? Ativo { get; set; }

        public virtual TblItensIngrediente IdIngredienteNavigation { get; set; }
        public virtual TblItensMov IdItensMovNavigation { get; set; }
    }
}
