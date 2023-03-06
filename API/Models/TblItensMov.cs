using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensMov
    {
        public TblItensMov()
        {
            TblItensIngredientesMovs = new HashSet<TblItensIngredientesMov>();
        }

        public long IdItensMov { get; set; }
        public string Sku { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public decimal Qtd { get; set; }
        public DateTime Data { get; set; }
        public string IdLocal { get; set; }
        public string Obs { get; set; }
        public bool? Ativo { get; set; }
        public string Unidade { get; set; }

        public virtual ICollection<TblItensIngredientesMov> TblItensIngredientesMovs { get; set; }
    }
}
