using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItens1Categorium
    {
        public TblItens1Categorium()
        {
            TblItens = new HashSet<TblIten>();
            TblItens2Grupos = new HashSet<TblItens2Grupo>();
        }

        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public string CategoriaTransacao { get; set; }
        public int? IdUsuario { get; set; }
        public TimeSpan DataCriacao { get; set; }

        public virtual ICollection<TblIten> TblItens { get; set; }
        public virtual ICollection<TblItens2Grupo> TblItens2Grupos { get; set; }
    }
}
