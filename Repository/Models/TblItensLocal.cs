using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblItensLocal
    {
        public string IdLocal { get; set; }
        public string Local { get; set; }
        public bool? Fisico { get; set; }
        public bool PontoVenda { get; set; }
    }
}
