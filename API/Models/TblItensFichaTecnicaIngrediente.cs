using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensFichaTecnicaIngrediente
    {
        public long IdFt { get; set; }
        public string Sku { get; set; }
        public decimal QtdBruta { get; set; }
        public decimal QtdLiquida { get; set; }
        public decimal Aproveitamento { get; set; }
        public string Unidade { get; set; }
        public decimal CustoBruto { get; set; }
        public decimal CustoLiquido { get; set; }
        public int LancadoPor { get; set; }
        public DateTime LancadoEm { get; set; }
    }
}
