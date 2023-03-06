using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblMensagemEnviadum
    {
        public int? Codreme { get; set; }
        public int? Coddest { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public TimeSpan? Data { get; set; }
        public char? Lida { get; set; }
        public char? Arquivar { get; set; }
        public string Destinatarios { get; set; }
        public string Novo { get; set; }
        public string Lixeira { get; set; }
        public string Excluido { get; set; }
        public int? Codmensagemenv { get; set; }
        public string Enviado { get; set; }
        public string Anexo { get; set; }
        public string Encresp { get; set; }
        public string Rascunho { get; set; }
        public int? Vincmsg { get; set; }
        public int? Encaminhada { get; set; }
        public int Codigo { get; set; }
    }
}
