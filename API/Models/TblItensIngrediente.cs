using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensIngrediente
    {
        public TblItensIngrediente()
        {
            TblItensIngredientesMovs = new HashSet<TblItensIngredientesMov>();
        }

        public int IdIngrediente { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public decimal? Custo { get; set; }
        public DateTime CadastradoEm { get; set; }
        public int? CadastradoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public int? AtualizadoPor { get; set; }
        public string Observacao { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<TblItensIngredientesMov> TblItensIngredientesMovs { get; set; }
    }
}
