using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItens2Grupo
    {
        public int IdGrupo { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public DateTime CadastradoEm { get; set; }
        public int CadastradoPor { get; set; }

        public virtual TblUsuario CadastradoPorNavigation { get; set; }
        public virtual TblItens1Categorium IdCategoriaNavigation { get; set; }
    }
}
