using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblConsumoComandaBarcode
    {
        public int IdComanda { get; set; }
        public string Barcode { get; set; }
        public bool? Utilizada { get; set; }
        public bool Funcionario { get; set; }
        public int? IdUsuario { get; set; }
    }
}
