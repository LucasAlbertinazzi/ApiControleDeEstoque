using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblItens1Categorium
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public string CategoriaTransacao { get; set; }
        public int? IdUsuario { get; set; }
        public TimeSpan DataCriacao { get; set; }
    }
}
