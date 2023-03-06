using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblUsuario
    {
        public TblUsuario()
        {
            TblCaixas = new HashSet<TblCaixa>();
            TblCaixasCheques = new HashSet<TblCaixasCheque>();
            TblConsumoMesaHistAbertaPorNavigations = new HashSet<TblConsumoMesaHist>();
            TblConsumoMesaHistFechadaPorNavigations = new HashSet<TblConsumoMesaHist>();
            TblFornecedoreAtualizadoPorNavigations = new HashSet<TblFornecedore>();
            TblFornecedoreCadastradoPorNavigations = new HashSet<TblFornecedore>();
            TblItenAtualizadoPorNavigations = new HashSet<TblIten>();
            TblItenCadastradoPorNavigations = new HashSet<TblIten>();
            TblItens2Grupos = new HashSet<TblItens2Grupo>();
            TblRecebimentos = new HashSet<TblRecebimento>();
            TblReservas = new HashSet<TblReserva>();
            TblSessoesUsuarios = new HashSet<TblSessoesUsuario>();
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Cpf { get; set; }
        public int? IdFuncao { get; set; }
        public string IdLocal { get; set; }
        public bool Alterarsenha { get; set; }
        public bool Bloqueado { get; set; }
        public string CriadoPor { get; set; }
        public bool PermissaoEspecial { get; set; }

        public virtual ICollection<TblCaixa> TblCaixas { get; set; }
        public virtual ICollection<TblCaixasCheque> TblCaixasCheques { get; set; }
        public virtual ICollection<TblConsumoMesaHist> TblConsumoMesaHistAbertaPorNavigations { get; set; }
        public virtual ICollection<TblConsumoMesaHist> TblConsumoMesaHistFechadaPorNavigations { get; set; }
        public virtual ICollection<TblFornecedore> TblFornecedoreAtualizadoPorNavigations { get; set; }
        public virtual ICollection<TblFornecedore> TblFornecedoreCadastradoPorNavigations { get; set; }
        public virtual ICollection<TblIten> TblItenAtualizadoPorNavigations { get; set; }
        public virtual ICollection<TblIten> TblItenCadastradoPorNavigations { get; set; }
        public virtual ICollection<TblItens2Grupo> TblItens2Grupos { get; set; }
        public virtual ICollection<TblRecebimento> TblRecebimentos { get; set; }
        public virtual ICollection<TblReserva> TblReservas { get; set; }
        public virtual ICollection<TblSessoesUsuario> TblSessoesUsuarios { get; set; }
    }
}
