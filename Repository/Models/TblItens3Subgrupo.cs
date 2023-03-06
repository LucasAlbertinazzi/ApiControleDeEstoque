using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblItens3Subgrupo
    {
        public int IdCategoria { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubgrupo { get; set; }
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
