using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblComprasSolicitacaoItensCotacao
    {
        public long IdCompraSolicitacaoItemCotacao { get; set; }
        public long IdCompraSolicitacaoItem { get; set; }
        public string CnpjFornecedor { get; set; }
        public DateTime CotadoEm { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public decimal Preco { get; set; }
        public string Unidade { get; set; }
    }
}
