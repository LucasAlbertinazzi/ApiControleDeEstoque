using System;

namespace Domain.Entities
{
    public class CarrinhoConsumo
    {
        public int IdItem { get; set; }
        public int SkuCb { get; set; }
        public string CodItemCb { get; set; }
        public string IdLocal { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdGrupo { get; set; }
        public int? IdSubgrupo { get; set; }
        public string Sku { get; set; }
        public decimal Volume { get; set; }
        public decimal Peso { get; set; }
        public bool? Ativo { get; set; }
        public DateTime CadastradoEm { get; set; }
        public long CadastradoPor { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public long AtualizadoPor { get; set; }
        public int? IdReceita { get; set; }
        public string Codbarra { get; set; }
        public bool InclusoReserva { get; set; }
        public decimal PrecoReserva { get; set; }
        public int LimiteReserva { get; set; }
        public string DescricaoCozinha { get; set; }
        public bool RefeicaoCompleta { get; set; }
        public bool ComplementoRefeicao { get; set; }

        public int idusuario { get; set; }

        public string observacao { get; set; }
        public int Quantidade { get; set; }






        public string tipo { get; set; }

        public int carrinhoIdMesa { get; set; }






        public int carrinhoIdComanda { get; set; }

        public string nomeCliente { get; set; }





        public int idReserva { get; set; }

        public string nomeHospede { get; set; }
        public string nomeQuarto { get; set; }

        public string prepedido { get; set; }

        public string dispositivo { get; set; }

    }
}
