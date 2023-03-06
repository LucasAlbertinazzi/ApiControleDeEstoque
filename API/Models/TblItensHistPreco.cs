using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensHistPreco
    {
        public long IdItemHistPreco { get; set; }
        public string Sku { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
    }
}
