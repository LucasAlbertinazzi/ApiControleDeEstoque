using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensIngredientesEstoque
    {
        public int IdIngrediente { get; set; }
        public string Local { get; set; }
        public int? IdUnIngrediente { get; set; }
        public decimal? Qtd { get; set; }
    }
}
