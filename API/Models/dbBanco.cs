using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.Models
{
    public partial class dbBanco : DbContext
    {
        public dbBanco()
        {
        }

        public dbBanco(DbContextOptions<dbBanco> options)
            : base(options)
        {
        }

        public virtual DbSet<CbHospede> CbHospedes { get; set; }
        public virtual DbSet<CbReserva> CbReservas { get; set; }
        public virtual DbSet<CbTransaco> CbTransacoes { get; set; }
        public virtual DbSet<ErrorLogsController> ErrorLogsControllers { get; set; }
        public virtual DbSet<TblCaixa> TblCaixas { get; set; }
        public virtual DbSet<TblCaixasCheque> TblCaixasCheques { get; set; }
        public virtual DbSet<TblCaixasFluxo> TblCaixasFluxos { get; set; }
        public virtual DbSet<TblCaixasHistorico> TblCaixasHistoricos { get; set; }
        public virtual DbSet<TblCaixasPermissao> TblCaixasPermissaos { get; set; }
        public virtual DbSet<TblCaixasTransferencium> TblCaixasTransferencia { get; set; }
        public virtual DbSet<TblCaixasVale> TblCaixasVales { get; set; }
        public virtual DbSet<TblCloudbedsToken> TblCloudbedsTokens { get; set; }
        public virtual DbSet<TblComprasSolicitacao> TblComprasSolicitacaos { get; set; }
        public virtual DbSet<TblComprasSolicitacaoIten> TblComprasSolicitacaoItens { get; set; }
        public virtual DbSet<TblComprasSolicitacaoItensCotacao> TblComprasSolicitacaoItensCotacaos { get; set; }
        public virtual DbSet<TblConsumo> TblConsumos { get; set; }
        public virtual DbSet<TblConsumoComandaBarcode> TblConsumoComandaBarcodes { get; set; }
        public virtual DbSet<TblConsumoComandum> TblConsumoComanda { get; set; }
        public virtual DbSet<TblConsumoCondicoesEspeciai> TblConsumoCondicoesEspeciais { get; set; }
        public virtual DbSet<TblConsumoFechado> TblConsumoFechados { get; set; }
        public virtual DbSet<TblConsumoImpressaoCozinha> TblConsumoImpressaoCozinhas { get; set; }
        public virtual DbSet<TblConsumoMesa> TblConsumoMesas { get; set; }
        public virtual DbSet<TblConsumoMesaHist> TblConsumoMesaHists { get; set; }
        public virtual DbSet<TblContaEstoque> TblContaEstoques { get; set; }
        public virtual DbSet<TblContaEstoquePre> TblContaEstoquePres { get; set; }
        public virtual DbSet<TblEntrega> TblEntregas { get; set; }
        public virtual DbSet<TblEntregaTipo> TblEntregaTipos { get; set; }
        public virtual DbSet<TblEntregaUf> TblEntregaUfs { get; set; }
        public virtual DbSet<TblFinanceiroDivPrinc> TblFinanceiroDivPrincs { get; set; }
        public virtual DbSet<TblFinanceiroDivSecun> TblFinanceiroDivSecuns { get; set; }
        public virtual DbSet<TblFinanceiroDivTerc> TblFinanceiroDivTercs { get; set; }
        public virtual DbSet<TblFornecedore> TblFornecedores { get; set; }
        public virtual DbSet<TblHospede> TblHospedes { get; set; }
        public virtual DbSet<TblImpressora> TblImpressoras { get; set; }
        public virtual DbSet<TblIten> TblItens { get; set; }
        public virtual DbSet<TblItens1Categorium> TblItens1Categoria { get; set; }
        public virtual DbSet<TblItens2Grupo> TblItens2Grupos { get; set; }
        public virtual DbSet<TblItens3Subgrupo> TblItens3Subgrupos { get; set; }
        public virtual DbSet<TblItensEstoque> TblItensEstoques { get; set; }
        public virtual DbSet<TblItensFichaTecnica> TblItensFichaTecnicas { get; set; }
        public virtual DbSet<TblItensFichaTecnicaIngrediente> TblItensFichaTecnicaIngredientes { get; set; }
        public virtual DbSet<TblItensHistPreco> TblItensHistPrecos { get; set; }
        public virtual DbSet<TblItensIngrediente> TblItensIngredientes { get; set; }
        public virtual DbSet<TblItensIngredientesEstoque> TblItensIngredientesEstoques { get; set; }
        public virtual DbSet<TblItensIngredientesHistPreco> TblItensIngredientesHistPrecos { get; set; }
        public virtual DbSet<TblItensIngredientesMov> TblItensIngredientesMovs { get; set; }
        public virtual DbSet<TblItensLocal> TblItensLocals { get; set; }
        public virtual DbSet<TblItensMov> TblItensMovs { get; set; }
        public virtual DbSet<TblItensMovTipo> TblItensMovTipos { get; set; }
        public virtual DbSet<TblItensMovTransferencium> TblItensMovTransferencia { get; set; }
        public virtual DbSet<TblItensPontoCarne> TblItensPontoCarnes { get; set; }
        public virtual DbSet<TblItensRefeicao> TblItensRefeicaos { get; set; }
        public virtual DbSet<TblItensUnidade> TblItensUnidades { get; set; }
        public virtual DbSet<TblLog> TblLogs { get; set; }
        public virtual DbSet<TblMensagem> TblMensagems { get; set; }
        public virtual DbSet<TblMensagemEnviadum> TblMensagemEnviada { get; set; }
        public virtual DbSet<TblMenu> TblMenus { get; set; }
        public virtual DbSet<TblNfEntradaItem> TblNfEntradaItems { get; set; }
        public virtual DbSet<TblNfEntradum> TblNfEntrada { get; set; }
        public virtual DbSet<TblOcorrChamado> TblOcorrChamados { get; set; }
        public virtual DbSet<TblOcorrChamadosReag> TblOcorrChamadosReags { get; set; }
        public virtual DbSet<TblOcorrServico> TblOcorrServicos { get; set; }
        public virtual DbSet<TblOcorrUsuario> TblOcorrUsuarios { get; set; }
        public virtual DbSet<TblPagamento> TblPagamentos { get; set; }
        public virtual DbSet<TblPagamentosLogVencimentoAlterado> TblPagamentosLogVencimentoAlterados { get; set; }
        public virtual DbSet<TblPagamentosTipo> TblPagamentosTipos { get; set; }
        public virtual DbSet<TblPedidoCompra> TblPedidoCompras { get; set; }
        public virtual DbSet<TblPedidoCompraSub> TblPedidoCompraSubs { get; set; }
        public virtual DbSet<TblPermisso> TblPermissoes { get; set; }
        public virtual DbSet<TblPermissoesAcessosFuncao> TblPermissoesAcessosFuncaos { get; set; }
        public virtual DbSet<TblPermissoesAcessosMenu> TblPermissoesAcessosMenus { get; set; }
        public virtual DbSet<TblPermissoesAcessosUsuario> TblPermissoesAcessosUsuarios { get; set; }
        public virtual DbSet<TblPermissoesForm> TblPermissoesForms { get; set; }
        public virtual DbSet<TblPesquisaHospede> TblPesquisaHospedes { get; set; }
        public virtual DbSet<TblEmpresa> TblEmpresas { get; set; }
        public virtual DbSet<TblRecebimento> TblRecebimentos { get; set; }
        public virtual DbSet<TblReserva> TblReservas { get; set; }
        public virtual DbSet<TblReservasComissaoAlq> TblReservasComissaoAlqs { get; set; }
        public virtual DbSet<TblReservasComissaoHistAutorizacao> TblReservasComissaoHistAutorizacaos { get; set; }
        public virtual DbSet<TblReservasFonte> TblReservasFontes { get; set; }
        public virtual DbSet<TblReservasHospede> TblReservasHospedes { get; set; }
        public virtual DbSet<TblReservasPensao> TblReservasPensaos { get; set; }
        public virtual DbSet<TblReservasStatus> TblReservasStatuses { get; set; }
        public virtual DbSet<TblSessoesUsuario> TblSessoesUsuarios { get; set; }
        public virtual DbSet<TblSuite> TblSuites { get; set; }
        public virtual DbSet<TblTransaco> TblTransacoes { get; set; }
        public virtual DbSet<TblTransacoesPasseio> TblTransacoesPasseios { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }
        public virtual DbSet<TblUsuariosFuncao> TblUsuariosFuncaos { get; set; }
        public virtual DbSet<TblUsuariosHistoricoLogin> TblUsuariosHistoricoLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C");

            modelBuilder.Entity<CbHospede>(entity =>
            {
                entity.HasKey(e => e.IdHospedeCb);

                entity.ToTable("cb_hospedes");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_hospede_cb");

                entity.Property(e => e.Celular)
                    .HasMaxLength(25)
                    .HasColumnName("celular")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .HasColumnName("cpf")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.DataCriacao).HasColumnName("data_criacao");

                entity.Property(e => e.DataModificacao).HasColumnName("data_modificacao");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .HasColumnName("nome")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(25)
                    .HasColumnName("telefone")
                    .HasDefaultValueSql("'empty'::character varying");
            });

            modelBuilder.Entity<CbReserva>(entity =>
            {
                entity.HasKey(e => e.IdReservaCb);

                entity.ToTable("cb_reservas");

                entity.Property(e => e.IdReservaCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_reserva_cb");

                entity.Property(e => e.Adultos)
                    .HasMaxLength(80)
                    .HasColumnName("adultos")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Criancas)
                    .HasMaxLength(40)
                    .HasColumnName("criancas")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("data_criacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataFinal).HasColumnName("data_final");

                entity.Property(e => e.DataInicio).HasColumnName("data_inicio");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Fonte)
                    .HasMaxLength(60)
                    .HasColumnName("fonte")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_hospede_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.ItensAdicionaisBalanco).HasColumnName("itens_adicionais_balanco");

                entity.Property(e => e.NomeHospede)
                    .HasMaxLength(60)
                    .HasColumnName("nome_hospede")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeQuarto)
                    .HasMaxLength(60)
                    .HasColumnName("nome_quarto")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.StatusHospede)
                    .HasMaxLength(40)
                    .HasColumnName("status_hospede")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Total)
                    .HasPrecision(13, 2)
                    .HasColumnName("total");

                entity.Property(e => e.TotalQuarto)
                    .HasMaxLength(80)
                    .HasColumnName("total_quarto")
                    .HasDefaultValueSql("'empty'::character varying");
            });

            modelBuilder.Entity<CbTransaco>(entity =>
            {
                entity.HasKey(e => e.IdTransacaoCb);

                entity.ToTable("cb_transacoes");

                entity.Property(e => e.IdTransacaoCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_transacao_cb");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(40)
                    .HasColumnName("categoria")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(180)
                    .HasColumnName("descricao")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_hospede_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdReservaCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_reserva_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(80)
                    .HasColumnName("nome_cliente")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeQuarto)
                    .HasMaxLength(60)
                    .HasColumnName("nome_quarto")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeUsuario)
                    .HasMaxLength(60)
                    .HasColumnName("nome_usuario")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Notas)
                    .HasMaxLength(200)
                    .HasColumnName("notas")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Valor)
                    .HasPrecision(13, 2)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<ErrorLogsController>(entity =>
            {
                entity.ToTable("error_logs_controllers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataErro).HasColumnName("data_erro");

                entity.Property(e => e.From)
                    .HasMaxLength(200)
                    .HasColumnName("from");

                entity.Property(e => e.InnerException)
                    .HasMaxLength(4000)
                    .HasColumnName("inner_exception");

                entity.Property(e => e.Json)
                    .HasMaxLength(10000)
                    .HasColumnName("json")
                    .HasDefaultValueSql("'n/a'::character varying");

                entity.Property(e => e.Message)
                    .HasMaxLength(4000)
                    .HasColumnName("message");
            });

            modelBuilder.Entity<TblCaixa>(entity =>
            {
                entity.HasKey(e => e.IdCaixa);

                entity.ToTable("tbl_caixas");

                entity.HasIndex(e => e.CriadoPor, "IX_tbl_caixas_criado_por");

                entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(30)
                    .HasColumnName("agencia");

                entity.Property(e => e.Banco)
                    .HasMaxLength(40)
                    .HasColumnName("banco");

                entity.Property(e => e.ChavePix)
                    .HasMaxLength(80)
                    .HasColumnName("chave_pix");

                entity.Property(e => e.ContaCorrente)
                    .HasMaxLength(40)
                    .HasColumnName("conta_corrente");

                entity.Property(e => e.CriadoPor).HasColumnName("criado_por");

                entity.Property(e => e.DataCriacao).HasColumnName("data_criacao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(200)
                    .HasColumnName("observacao");

                entity.Property(e => e.SenhaChave)
                    .HasMaxLength(50)
                    .HasColumnName("senha_chave")
                    .IsFixedLength(true);

                entity.Property(e => e.SenhaConta)
                    .HasMaxLength(50)
                    .HasColumnName("senha_conta");

                entity.Property(e => e.SenhaSeisDigitos)
                    .HasMaxLength(50)
                    .HasColumnName("senha_seis_digitos");

                entity.Property(e => e.Site)
                    .HasMaxLength(100)
                    .HasColumnName("site");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(40)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.TblCaixas)
                    .HasForeignKey(d => d.CriadoPor);
            });

            modelBuilder.Entity<TblCaixasCheque>(entity =>
            {
                entity.HasKey(e => e.IdCheque);

                entity.ToTable("tbl_caixas_cheque");

                entity.HasIndex(e => e.CadastradoPor, "IX_tbl_caixas_cheque_cadastrado_por");

                entity.HasIndex(e => e.IdCaixa, "IX_tbl_caixas_cheque_id_caixa");

                entity.HasIndex(e => e.IdReserva, "IX_tbl_caixas_cheque_id_reserva");

                entity.Property(e => e.IdCheque).HasColumnName("id_cheque");

                entity.Property(e => e.Agencia)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("agencia");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("banco");

                entity.Property(e => e.CadastradoPor).HasColumnName("cadastrado_por");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("conta");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cpf");

                entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");

                entity.Property(e => e.IdReserva).HasColumnName("id_reserva");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("nome");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("numero");

                entity.Property(e => e.Predatado).HasColumnName("predatado");

                entity.Property(e => e.Valor)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor");

                entity.Property(e => e.Vencimento).HasColumnName("vencimento");

                entity.HasOne(d => d.CadastradoPorNavigation)
                    .WithMany(p => p.TblCaixasCheques)
                    .HasForeignKey(d => d.CadastradoPor);

                entity.HasOne(d => d.IdCaixaNavigation)
                    .WithMany(p => p.TblCaixasCheques)
                    .HasForeignKey(d => d.IdCaixa);

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.TblCaixasCheques)
                    .HasForeignKey(d => d.IdReserva);
            });

            modelBuilder.Entity<TblCaixasFluxo>(entity =>
            {
                entity.HasKey(e => e.IdFluxo);

                entity.ToTable("tbl_caixas_fluxo");

                entity.HasIndex(e => e.IdCaixa, "IX_tbl_caixas_fluxo_id_caixa");

                entity.Property(e => e.IdFluxo).HasColumnName("id_fluxo");

                entity.Property(e => e.Aberto).HasColumnName("aberto");

                entity.Property(e => e.CaixaFinal)
                    .HasPrecision(14, 2)
                    .HasColumnName("caixa_final");

                entity.Property(e => e.CaixaInicial)
                    .HasPrecision(14, 2)
                    .HasColumnName("caixa_inicial");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entradas)
                    .HasPrecision(14, 2)
                    .HasColumnName("entradas");

                entity.Property(e => e.FechadoEm).HasColumnName("fechado_em");

                entity.Property(e => e.FechadoPor).HasColumnName("fechado_por");

                entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");

                entity.Property(e => e.Saidas)
                    .HasPrecision(14, 2)
                    .HasColumnName("saidas");

                entity.Property(e => e.UtilizadoPor).HasColumnName("utilizado_por");
            });

            modelBuilder.Entity<TblCaixasHistorico>(entity =>
            {
                entity.HasKey(e => e.IdCaixasHistorico)
                    .HasName("id_caixas_historico_pkey");

                entity.ToTable("tbl_caixas_historico");

                entity.Property(e => e.IdCaixasHistorico)
                    .HasColumnName("id_caixas_historico")
                    .HasDefaultValueSql("nextval('id_caixas_historico_id_caixas_historico_seq'::regclass)");

                entity.Property(e => e.Acrescimo).HasColumnName("acrescimo");

                entity.Property(e => e.Desconto).HasColumnName("desconto");

                entity.Property(e => e.IdDocumento).HasColumnName("id_documento");

                entity.Property(e => e.IdFluxo).HasColumnName("id_fluxo");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tipo");

                entity.Property(e => e.ValorTotal).HasColumnName("valor_total");
            });

            modelBuilder.Entity<TblCaixasPermissao>(entity =>
            {
                entity.HasKey(e => e.IdCaixasPermissao)
                    .HasName("tbl_caixas_permissao_pkey");

                entity.ToTable("tbl_caixas_permissao");

                entity.Property(e => e.IdCaixasPermissao).HasColumnName("id_caixas_permissao");

                entity.Property(e => e.ConcedidoEm).HasColumnName("concedido_em");

                entity.Property(e => e.ConcedidoPor).HasColumnName("concedido_por");

                entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            });

            modelBuilder.Entity<TblCaixasTransferencium>(entity =>
            {
                entity.HasKey(e => e.IdCaixasTransferencia)
                    .HasName("tbl_caixas_transferencia_pkey");

                entity.ToTable("tbl_caixas_transferencia");

                entity.Property(e => e.IdCaixasTransferencia).HasColumnName("id_caixas_transferencia");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Forma)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("forma");

                entity.Property(e => e.IdCaixaDestino).HasColumnName("id_caixa_destino");

                entity.Property(e => e.IdFluxoDestino).HasColumnName("id_fluxo_destino");

                entity.Property(e => e.IdFluxoOrigem).HasColumnName("id_fluxo_origem");

                entity.Property(e => e.Recebido).HasColumnName("recebido");

                entity.Property(e => e.RecebidoEm).HasColumnName("recebido_em");

                entity.Property(e => e.RecebidoPor).HasColumnName("recebido_por");

                entity.Property(e => e.TransferidoPor).HasColumnName("transferido_por");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<TblCaixasVale>(entity =>
            {
                entity.HasKey(e => e.IdCaixasVale)
                    .HasName("tbl_caixas_vale_pkey");

                entity.ToTable("tbl_caixas_vale");

                entity.Property(e => e.IdCaixasVale).HasColumnName("id_caixas_vale");

                entity.Property(e => e.IdFluxo).HasColumnName("id_fluxo");

                entity.Property(e => e.IdPedidoCompra).HasColumnName("id_pedido_compra");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.MetodoVale)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("metodo_vale");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TblCloudbedsToken>(entity =>
            {
                entity.ToTable("tbl_cloudbeds_token");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasColumnName("access_token");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Expires).HasColumnName("expires");

                entity.Property(e => e.RefreshToken)
                    .IsRequired()
                    .HasColumnName("refresh_token");

                entity.Property(e => e.TokenType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("token_type");
            });

            modelBuilder.Entity<TblComprasSolicitacao>(entity =>
            {
                entity.HasKey(e => e.IdCompraSolicitacao)
                    .HasName("tbl_compras_solicitacao_pkey");

                entity.ToTable("tbl_compras_solicitacao");

                entity.Property(e => e.IdCompraSolicitacao).HasColumnName("id_compra_solicitacao");

                entity.Property(e => e.Finalizada).HasColumnName("finalizada");

                entity.Property(e => e.SolicitadoEm).HasColumnName("solicitado_em");

                entity.Property(e => e.SolicitadoPor).HasColumnName("solicitado_por");
            });

            modelBuilder.Entity<TblComprasSolicitacaoIten>(entity =>
            {
                entity.HasKey(e => e.IdCompraSolicitacaoItem)
                    .HasName("tbl_compras_solicitacao_itens_pkey");

                entity.ToTable("tbl_compras_solicitacao_itens");

                entity.Property(e => e.IdCompraSolicitacaoItem).HasColumnName("id_compra_solicitacao_item");

                entity.Property(e => e.Comprado).HasColumnName("comprado");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdCompraSolicitacao).HasColumnName("id_compra_solicitacao");

                entity.Property(e => e.LancadoEm).HasColumnName("lancado_em");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Sku)
                    .HasMaxLength(14)
                    .HasColumnName("sku");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("unidade");
            });

            modelBuilder.Entity<TblComprasSolicitacaoItensCotacao>(entity =>
            {
                entity.HasKey(e => e.IdCompraSolicitacaoItemCotacao)
                    .HasName("tbl_compras_solicitacao_itens_cotacao_pkey");

                entity.ToTable("tbl_compras_solicitacao_itens_cotacao");

                entity.Property(e => e.IdCompraSolicitacaoItemCotacao)
                    .HasColumnName("id_compra_solicitacao_item_cotacao")
                    .HasDefaultValueSql("nextval('tbl_compras_solicitacao_itens_id_compra_solicitacao_item_co_seq'::regclass)");

                entity.Property(e => e.CnpjFornecedor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("cnpj_fornecedor");

                entity.Property(e => e.Contato)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contato");

                entity.Property(e => e.CotadoEm).HasColumnName("cotado_em");

                entity.Property(e => e.IdCompraSolicitacaoItem).HasColumnName("id_compra_solicitacao_item");

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("telefone");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(15)
                    .HasColumnName("unidade");
            });

            modelBuilder.Entity<TblConsumo>(entity =>
            {
                entity.HasKey(e => e.IdConsumo)
                    .HasName("tbl_consumo_pkey");

                entity.ToTable("tbl_consumo");

                entity.HasComment("consumo de itens");

                entity.Property(e => e.IdConsumo).HasColumnName("id_consumo");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataSolicitadoCozinha)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("data_solicitado_cozinha");

                entity.Property(e => e.Dispositivo)
                    .HasMaxLength(15)
                    .HasColumnName("dispositivo");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.Estornado).HasColumnName("estornado");

                entity.Property(e => e.EstornadoEm).HasColumnName("estornado_em");

                entity.Property(e => e.EstornadoObs)
                    .HasMaxLength(300)
                    .HasColumnName("estornado_obs");

                entity.Property(e => e.EstornadoPor).HasColumnName("estornado_por");

                entity.Property(e => e.IdConsumoFechado).HasColumnName("id_consumo_fechado");

                entity.Property(e => e.IdLocal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.IdTransacao).HasColumnName("id_transacao");

                entity.Property(e => e.Impresso).HasColumnName("impresso");

                entity.Property(e => e.ImpressoCozinha).HasColumnName("impresso_cozinha");

                entity.Property(e => e.ImpressoEm).HasColumnName("impresso_em");

                entity.Property(e => e.ImpressoPor).HasColumnName("impresso_por");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.LocalAlteradoUser)
                    .HasMaxLength(30)
                    .HasColumnName("local_alterado_user");

                entity.Property(e => e.Mesa).HasColumnName("mesa");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Obs)
                    .HasMaxLength(300)
                    .HasColumnName("obs");

                entity.Property(e => e.ObsLocalAlterado)
                    .HasMaxLength(100)
                    .HasColumnName("obs_local_alterado");

                entity.Property(e => e.Pago).HasColumnName("pago");

                entity.Property(e => e.Prepedido)
                    .HasColumnType("character varying")
                    .HasColumnName("prepedido");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.SolicitadoCozinha)
                    .HasColumnName("solicitado_cozinha")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tipo");

                entity.Property(e => e.UsuarioSolicitadoCozinha).HasColumnName("usuario_solicitado_cozinha");

                entity.Property(e => e.ValorTotal).HasColumnName("valor_total");
            });

            modelBuilder.Entity<TblConsumoComandaBarcode>(entity =>
            {
                entity.HasKey(e => e.IdComanda)
                    .HasName("tbl_consumo_comanda_barcode_pkey");

                entity.ToTable("tbl_consumo_comanda_barcode");

                entity.HasComment("dados de cada comanda, barcode");

                entity.Property(e => e.IdComanda)
                    .ValueGeneratedNever()
                    .HasColumnName("id_comanda");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(40)
                    .HasColumnName("barcode");

                entity.Property(e => e.Funcionario).HasColumnName("funcionario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Utilizada).HasColumnName("utilizada");
            });

            modelBuilder.Entity<TblConsumoComandum>(entity =>
            {
                entity.HasKey(e => new { e.IdComanda, e.Data, e.Hora })
                    .HasName("tbl_consumo_comanda_pkey");

                entity.ToTable("tbl_consumo_comanda");

                entity.HasComment("listagem comandas diário");

                entity.Property(e => e.IdComanda).HasColumnName("id_comanda");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Hora)
                    .HasColumnType("time without time zone")
                    .HasColumnName("hora");

                entity.Property(e => e.Fechada).HasColumnName("fechada");

                entity.Property(e => e.FechadaEm).HasColumnName("fechada_em");

                entity.Property(e => e.FechadaPor).HasColumnName("fechada_por");

                entity.Property(e => e.GeradaPor).HasColumnName("gerada_por");

                entity.Property(e => e.Mesa).HasColumnName("mesa");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(200)
                    .HasColumnName("nome_cliente");

                entity.Property(e => e.Obs)
                    .HasMaxLength(300)
                    .HasColumnName("obs");
            });

            modelBuilder.Entity<TblConsumoCondicoesEspeciai>(entity =>
            {
                entity.HasKey(e => e.IdConsumoCe)
                    .HasName("tbl_consumo_condicoes_especiais_pkey");

                entity.ToTable("tbl_consumo_condicoes_especiais");

                entity.Property(e => e.IdConsumoCe).HasColumnName("id_consumo_ce");

                entity.Property(e => e.CriadaEm)
                    .HasColumnName("criada_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CriadoPor).HasColumnName("criado_por");

                entity.Property(e => e.Desconto).HasColumnName("desconto");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.ValidadeFim).HasColumnName("validade_fim");

                entity.Property(e => e.ValidadeInicio).HasColumnName("validade_inicio");
            });

            modelBuilder.Entity<TblConsumoFechado>(entity =>
            {
                entity.HasKey(e => e.IdConsumoFechado)
                    .HasName("tbl_consumo_fechado_pkey");

                entity.ToTable("tbl_consumo_fechado");

                entity.HasComment("consumos que foram pagos.");

                entity.Property(e => e.IdConsumoFechado).HasColumnName("id_consumo_fechado");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Desconto).HasColumnName("desconto");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.ErroFechamento).HasColumnName("erro_fechamento");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(200)
                    .HasColumnName("observacao");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.Property(e => e.TaxaServico).HasColumnName("taxa_servico");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tipo");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<TblConsumoImpressaoCozinha>(entity =>
            {
                entity.HasKey(e => e.IdImpressaoCozinha)
                    .HasName("tbl_consumo_impressao_cozinha_pkey");

                entity.ToTable("tbl_consumo_impressao_cozinha");

                entity.Property(e => e.IdImpressaoCozinha).HasColumnName("id_impressao_cozinha");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Documento)
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.IdMesa).HasColumnName("id_mesa");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Impresso).HasColumnName("impresso");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .HasColumnName("tipo");

                entity.Property(e => e.TipoImpressao)
                    .HasColumnType("character varying")
                    .HasColumnName("tipo_impressao");
            });

            modelBuilder.Entity<TblConsumoMesa>(entity =>
            {
                entity.HasKey(e => e.IdMesa)
                    .HasName("tbl_consumo_mesa_pkey");

                entity.ToTable("tbl_consumo_mesa");

                entity.Property(e => e.IdMesa).HasColumnName("id_mesa");

                entity.Property(e => e.Utilizada).HasColumnName("utilizada");
            });

            modelBuilder.Entity<TblConsumoMesaHist>(entity =>
            {
                entity.HasKey(e => e.IdHistMesa)
                    .HasName("id_mesa");

                entity.ToTable("tbl_consumo_mesa_hist");

                entity.Property(e => e.IdHistMesa).HasColumnName("id_hist_mesa");

                entity.Property(e => e.AbertaEm).HasColumnName("aberta_em");

                entity.Property(e => e.AbertaPor).HasColumnName("aberta_por");

                entity.Property(e => e.Documento)
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.FechadaEm).HasColumnName("fechada_em");

                entity.Property(e => e.FechadaPor).HasColumnName("fechada_por");

                entity.Property(e => e.IdMesa).HasColumnName("id_mesa");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("'Reserva'::character varying");

                entity.HasOne(d => d.AbertaPorNavigation)
                    .WithMany(p => p.TblConsumoMesaHistAbertaPorNavigations)
                    .HasForeignKey(d => d.AbertaPor)
                    .HasConstraintName("aberta_por");

                entity.HasOne(d => d.FechadaPorNavigation)
                    .WithMany(p => p.TblConsumoMesaHistFechadaPorNavigations)
                    .HasForeignKey(d => d.FechadaPor)
                    .HasConstraintName("fechada_por");
            });

            modelBuilder.Entity<TblContaEstoque>(entity =>
            {
                entity.ToTable("tbl_conta_estoque");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataAbre).HasColumnName("data_abre");

                entity.Property(e => e.DataFecha).HasColumnName("data_fecha");

                entity.Property(e => e.Excluir)
                    .HasMaxLength(1)
                    .HasColumnName("excluir");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(1)
                    .HasColumnName("finalizado");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdLista).HasColumnName("id_lista");

                entity.Property(e => e.IdLocal)
                    .HasColumnType("character varying")
                    .HasColumnName("id_local");

                entity.Property(e => e.Idcategorialista).HasColumnName("idcategorialista");

                entity.Property(e => e.UserAbre)
                    .HasColumnType("character varying")
                    .HasColumnName("user_abre");

                entity.Property(e => e.UserExcluir)
                    .HasColumnType("character varying")
                    .HasColumnName("user_excluir");

                entity.Property(e => e.UserFecha)
                    .HasColumnType("character varying")
                    .HasColumnName("user_fecha");
            });

            modelBuilder.Entity<TblContaEstoquePre>(entity =>
            {
                entity.ToTable("tbl_conta_estoque_pre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datasave).HasColumnName("datasave");

                entity.Property(e => e.Estoqueatual).HasColumnName("estoqueatual");

                entity.Property(e => e.Finaliza)
                    .HasMaxLength(1)
                    .HasColumnName("finaliza");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.Property(e => e.Iditem).HasColumnName("iditem");

                entity.Property(e => e.Idlista).HasColumnName("idlista");

                entity.Property(e => e.Idlocal)
                    .HasColumnType("character varying")
                    .HasColumnName("idlocal");

                entity.Property(e => e.Idsubgrupo).HasColumnName("idsubgrupo");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Sku)
                    .HasColumnType("character varying")
                    .HasColumnName("sku");

                entity.Property(e => e.Usuario)
                    .HasColumnType("character varying")
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<TblEntrega>(entity =>
            {
                entity.HasKey(e => e.IdEntrega)
                    .HasName("tbl_entrega_pkey");

                entity.ToTable("tbl_entrega");

                entity.HasComment("dados de um endereço de entrega. Utilizado para entregas próprias, feitas por nós, ou recebimento mercadorias");

                entity.Property(e => e.IdEntrega).HasColumnName("id_entrega");

                entity.Property(e => e.Documento)
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.EndBairro)
                    .HasMaxLength(50)
                    .HasColumnName("end_bairro");

                entity.Property(e => e.EndCep)
                    .HasMaxLength(20)
                    .HasColumnName("end_cep");

                entity.Property(e => e.EndCidade)
                    .HasMaxLength(50)
                    .HasColumnName("end_cidade");

                entity.Property(e => e.EndComplemento)
                    .HasMaxLength(50)
                    .HasColumnName("end_complemento");

                entity.Property(e => e.EndNumero)
                    .HasMaxLength(20)
                    .HasColumnName("end_numero");

                entity.Property(e => e.EndPais)
                    .HasMaxLength(30)
                    .HasColumnName("end_pais");

                entity.Property(e => e.EndUf)
                    .HasMaxLength(3)
                    .HasColumnName("end_uf");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .HasColumnName("endereco");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .HasColumnName("tipo");

                entity.Property(e => e.TipoEntrega).HasColumnName("tipo_entrega");
            });

            modelBuilder.Entity<TblEntregaTipo>(entity =>
            {
                entity.HasKey(e => e.IdEntregaTipo)
                    .HasName("tbl_entrega_tipo_pkey");

                entity.ToTable("tbl_entrega_tipo");

                entity.Property(e => e.IdEntregaTipo).HasColumnName("id_entrega_tipo");

                entity.Property(e => e.Descricao).HasColumnName("descricao");

                entity.Property(e => e.DescricaoResumida)
                    .HasMaxLength(200)
                    .HasColumnName("descricao_resumida");

                entity.Property(e => e.Responsabilidade)
                    .HasMaxLength(20)
                    .HasColumnName("responsabilidade");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TblEntregaUf>(entity =>
            {
                entity.HasKey(e => e.CodigoUf)
                    .HasName("tbl_entrega_uf_pkey");

                entity.ToTable("tbl_entrega_uf");

                entity.Property(e => e.CodigoUf)
                    .HasColumnName("codigo_uf")
                    .HasDefaultValueSql("nextval('tbl_entrega_uf_id_uf_seq'::regclass)");

                entity.Property(e => e.Uf)
                    .HasMaxLength(3)
                    .HasColumnName("uf");

                entity.Property(e => e.UnidadeFederacao)
                    .HasMaxLength(100)
                    .HasColumnName("unidade_federacao");
            });

            modelBuilder.Entity<TblFinanceiroDivPrinc>(entity =>
            {
                entity.HasKey(e => e.IdDivPrinc);

                entity.ToTable("tbl_financeiro_div_princ");

                entity.Property(e => e.IdDivPrinc).HasColumnName("id_div_princ");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<TblFinanceiroDivSecun>(entity =>
            {
                entity.HasKey(e => e.IdDivSecun);

                entity.ToTable("tbl_financeiro_div_secun");

                entity.HasIndex(e => e.IdDivPrinc, "IX_tbl_financeiro_div_secun_id_div_princ");

                entity.Property(e => e.IdDivSecun).HasColumnName("id_div_secun");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("descricao");

                entity.Property(e => e.IdDivPrinc).HasColumnName("id_div_princ");

                entity.HasOne(d => d.IdDivPrincNavigation)
                    .WithMany(p => p.TblFinanceiroDivSecuns)
                    .HasForeignKey(d => d.IdDivPrinc)
                    .HasConstraintName("FK_tbl_financeiro_div_secun_tbl_financeiro_div_princ_id_div_pr~");
            });

            modelBuilder.Entity<TblFinanceiroDivTerc>(entity =>
            {
                entity.HasKey(e => new { e.IdDivPrinc, e.IdDivSecun, e.IdDivTerc })
                    .HasName("tbl_financeiro_div_terc_pkey");

                entity.ToTable("tbl_financeiro_div_terc");

                entity.Property(e => e.IdDivPrinc).HasColumnName("id_div_princ");

                entity.Property(e => e.IdDivSecun).HasColumnName("id_div_secun");

                entity.Property(e => e.IdDivTerc).HasColumnName("id_div_terc");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            });

            modelBuilder.Entity<TblFornecedore>(entity =>
            {
                entity.HasKey(e => e.Cnpj)
                    .HasName("tbl_fornecedores_pkey");

                entity.ToTable("tbl_fornecedores");

                entity.HasIndex(e => e.AtualizadoPor, "IX_tbl_fornecedores_atualizado_por");

                entity.HasIndex(e => e.CadastradoPor, "IX_tbl_fornecedores_cadastrado_por");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AtualizadoEm).HasColumnName("atualizado_em");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(60)
                    .HasColumnName("bairro");

                entity.Property(e => e.CadastradoEm).HasColumnName("cadastrado_em");

                entity.Property(e => e.CadastradoPor)
                    .HasColumnName("cadastrado_por")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .HasColumnName("celular");

                entity.Property(e => e.Cep)
                    .HasMaxLength(25)
                    .HasColumnName("cep");

                entity.Property(e => e.ChavePix)
                    .HasMaxLength(50)
                    .HasColumnName("chave_pix");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(60)
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(100)
                    .HasColumnName("complemento");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(80)
                    .HasColumnName("endereco");

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(18)
                    .HasColumnName("inscricao_estadual");

                entity.Property(e => e.InscricaoMunicipal)
                    .HasMaxLength(18)
                    .HasColumnName("inscricao_municipal");

                entity.Property(e => e.NomeContato)
                    .HasMaxLength(40)
                    .HasColumnName("nome_contato");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(80)
                    .HasColumnName("nome_fantasia");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .HasColumnName("numero");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.Pais)
                    .HasMaxLength(60)
                    .HasColumnName("pais")
                    .HasDefaultValueSql("'BRASIL'::character varying");

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("razao_social");

                entity.Property(e => e.Site)
                    .HasMaxLength(200)
                    .HasColumnName("site");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(18)
                    .HasColumnName("telefone");

                entity.Property(e => e.Uf)
                    .HasMaxLength(3)
                    .HasColumnName("uf");

                entity.HasOne(d => d.AtualizadoPorNavigation)
                    .WithMany(p => p.TblFornecedoreAtualizadoPorNavigations)
                    .HasForeignKey(d => d.AtualizadoPor)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CadastradoPorNavigation)
                    .WithMany(p => p.TblFornecedoreCadastradoPorNavigations)
                    .HasForeignKey(d => d.CadastradoPor);
            });

            modelBuilder.Entity<TblHospede>(entity =>
            {
                entity.HasKey(e => e.IdHospede);

                entity.ToTable("tbl_hospedes");

                entity.Property(e => e.IdHospede).HasColumnName("id_hospede");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(30)
                    .HasColumnName("apelido");

                entity.Property(e => e.CadastradoEm)
                    .HasColumnName("cadastrado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CadastradoPor)
                    .HasColumnName("cadastrado_por")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .HasColumnName("celular")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .HasColumnName("cpf")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("data_criacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataModificacao)
                    .HasColumnName("data_modificacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("data_nascimento");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Escola)
                    .HasMaxLength(300)
                    .HasColumnName("escola");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_hospede_cb");

                entity.Property(e => e.IntoleranteGluten).HasColumnName("intolerante_gluten");

                entity.Property(e => e.IntoleranteLactose).HasColumnName("intolerante_lactose");

                entity.Property(e => e.ModificadoPor).HasColumnName("modificado_por");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .HasColumnName("nome")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.OutrasRestricoesAlim)
                    .HasMaxLength(300)
                    .HasColumnName("outras_restricoes_alim");

                entity.Property(e => e.Profissao)
                    .HasMaxLength(100)
                    .HasColumnName("profissao");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(25)
                    .HasColumnName("telefone")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Vegano).HasColumnName("vegano");

                entity.Property(e => e.Vegetariano).HasColumnName("vegetariano");
            });

            modelBuilder.Entity<TblImpressora>(entity =>
            {
                entity.HasKey(e => e.IdImpressora)
                    .HasName("tbl_impressoras_pkey");

                entity.ToTable("tbl_impressoras");

                entity.HasComment("dados impressoras de rede");

                entity.Property(e => e.IdImpressora).HasColumnName("id_impressora");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .HasColumnName("ip");

                entity.Property(e => e.ModeloImpressora)
                    .HasMaxLength(30)
                    .HasColumnName("modelo_impressora");

                entity.Property(e => e.NomeSpooler)
                    .HasMaxLength(30)
                    .HasColumnName("nome_spooler");
            });

            modelBuilder.Entity<TblIten>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("tbl_itens_pkey");

                entity.ToTable("tbl_itens");

                entity.HasComment("itens de consumo, tanto produtos quanto serviços");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AtualizadoEm)
                    .HasColumnName("atualizado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.BarPiscina).HasColumnName("bar_piscina");

                entity.Property(e => e.CadastradoEm)
                    .HasColumnName("cadastrado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CadastradoPor)
                    .HasColumnName("cadastrado_por")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CodItemCb)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cod_item_cb")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Codbarra)
                    .HasColumnType("character varying")
                    .HasColumnName("codbarra");

                entity.Property(e => e.ComplementoRefeicao).HasColumnName("complemento_refeicao");

                entity.Property(e => e.Cozinha).HasColumnName("cozinha");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .HasColumnName("descricao");

                entity.Property(e => e.DescricaoCozinha)
                    .HasMaxLength(100)
                    .HasColumnName("descricao_cozinha")
                    .HasComment("descrição reduzida para uso na cozinha");

                entity.Property(e => e.Drink).HasColumnName("drink");

                entity.Property(e => e.Ean)
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdFt).HasColumnName("id_ft");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdReceita).HasColumnName("id_receita");

                entity.Property(e => e.IdSubgrupo).HasColumnName("id_subgrupo");

                entity.Property(e => e.InclusoReserva).HasColumnName("incluso_reserva");

                entity.Property(e => e.LimiteReserva).HasColumnName("limite_reserva");

                entity.Property(e => e.Peso)
                    .HasPrecision(8, 2)
                    .HasColumnName("peso")
                    .HasComment("peso em gramas");

                entity.Property(e => e.Preco)
                    .HasPrecision(10, 2)
                    .HasColumnName("preco");

                entity.Property(e => e.PrecoReserva).HasColumnName("preco_reserva");

                entity.Property(e => e.RefeicaoCompleta).HasColumnName("refeicao_completa");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.SkuCb).HasColumnName("sku_cb");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("unidade")
                    .HasDefaultValueSql("'un'::character varying");

                entity.Property(e => e.Volume)
                    .HasPrecision(8, 2)
                    .HasColumnName("volume")
                    .HasComment("volume em ML");

                entity.HasOne(d => d.AtualizadoPorNavigation)
                    .WithMany(p => p.TblItenAtualizadoPorNavigations)
                    .HasForeignKey(d => d.AtualizadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atualizado_por");

                entity.HasOne(d => d.CadastradoPorNavigation)
                    .WithMany(p => p.TblItenCadastradoPorNavigations)
                    .HasForeignKey(d => d.CadastradoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cadastrado_por");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TblItens)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("id_categoria");
            });

            modelBuilder.Entity<TblItens1Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("tbl_itens_1_categoria_pkey");

                entity.ToTable("tbl_itens_1_categoria");

                entity.HasComment("Classificação dos itens,\n1-Categoria\n2-Grupo\n3-Subgrupo");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.CategoriaTransacao)
                    .HasMaxLength(40)
                    .HasColumnName("categoria_transacao");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("time without time zone")
                    .HasColumnName("data_criacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            });

            modelBuilder.Entity<TblItens2Grupo>(entity =>
            {
                entity.HasKey(e => new { e.IdGrupo, e.IdCategoria })
                    .HasName("tbl_itens_2_grupo_pkey");

                entity.ToTable("tbl_itens_2_grupo");

                entity.HasComment("Classificação dos itens,\n1-Categoria\n2-Grupo\n3-Subgrupo");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.CadastradoEm)
                    .HasColumnName("cadastrado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CadastradoPor)
                    .HasColumnName("cadastrado_por")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(40)
                    .HasColumnName("descricao");

                entity.HasOne(d => d.CadastradoPorNavigation)
                    .WithMany(p => p.TblItens2Grupos)
                    .HasForeignKey(d => d.CadastradoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cadastrado_por");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TblItens2Grupos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_categoria");
            });

            modelBuilder.Entity<TblItens3Subgrupo>(entity =>
            {
                entity.HasKey(e => new { e.IdCategoria, e.IdGrupo, e.IdSubgrupo })
                    .HasName("tbl_itens_3_subgrupo_pkey");

                entity.ToTable("tbl_itens_3_subgrupo");

                entity.HasComment("Classificação dos itens,\n1-Categoria\n2-Grupo\n3-Subgrupo");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdSubgrupo).HasColumnName("id_subgrupo");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("data_criacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            });

            modelBuilder.Entity<TblItensEstoque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_itens_estoque");

                entity.HasComment("local em que cada item está e seu estoque");

                entity.Property(e => e.IdItemEstoque).HasColumnName("id_item_estoque");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");
            });

            modelBuilder.Entity<TblItensFichaTecnica>(entity =>
            {
                entity.HasKey(e => e.IdFt)
                    .HasName("tbl_itens_ficha_tecnica_pkey");

                entity.ToTable("tbl_itens_ficha_tecnica");

                entity.Property(e => e.IdFt).HasColumnName("id_ft");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CriadaEm)
                    .HasColumnName("criada_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CriadaPor).HasColumnName("criada_por");

                entity.Property(e => e.CustoPorcao).HasColumnName("custo_porcao");

                entity.Property(e => e.CustoReceita).HasColumnName("custo_receita");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("descricao");

                entity.Property(e => e.ModoPreparo)
                    .HasMaxLength(500)
                    .HasColumnName("modo_preparo");

                entity.Property(e => e.RendimentoPorcoes).HasColumnName("rendimento_porcoes");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");
            });

            modelBuilder.Entity<TblItensFichaTecnicaIngrediente>(entity =>
            {
                entity.HasKey(e => new { e.IdFt, e.Sku })
                    .HasName("tbl_itens_ficha_tecnica_ingredientes_pkey");

                entity.ToTable("tbl_itens_ficha_tecnica_ingredientes");

                entity.HasComment("ingredientes de uma ficha técnica");

                entity.Property(e => e.IdFt).HasColumnName("id_ft");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.Aproveitamento)
                    .HasPrecision(5, 2)
                    .HasColumnName("aproveitamento");

                entity.Property(e => e.CustoBruto).HasColumnName("custo_bruto");

                entity.Property(e => e.CustoLiquido).HasColumnName("custo_liquido");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.QtdBruta).HasColumnName("qtd_bruta");

                entity.Property(e => e.QtdLiquida).HasColumnName("qtd_liquida");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("unidade")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblItensHistPreco>(entity =>
            {
                entity.HasKey(e => e.IdItemHistPreco)
                    .HasName("tbl_itens_hist_preco_pkey");

                entity.ToTable("tbl_itens_hist_preco");

                entity.HasComment("histórico de preço de um item");

                entity.Property(e => e.IdItemHistPreco).HasColumnName("id_item_hist_preco");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Preco)
                    .HasPrecision(10, 2)
                    .HasColumnName("preco");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");
            });

            modelBuilder.Entity<TblItensIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente)
                    .HasName("tbl_itens_ingredientes_pkey");

                entity.ToTable("tbl_itens_ingredientes");

                entity.HasComment("ingredientes utilizados nos alimentos");

                entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AtualizadoEm).HasColumnName("atualizado_em");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.CadastradoEm)
                    .HasColumnName("cadastrado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CadastradoPor).HasColumnName("cadastrado_por");

                entity.Property(e => e.Custo).HasColumnName("custo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(250)
                    .HasColumnName("observacao");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(10)
                    .HasColumnName("unidade");
            });

            modelBuilder.Entity<TblItensIngredientesEstoque>(entity =>
            {
                entity.HasKey(e => new { e.IdIngrediente, e.Local })
                    .HasName("tbl_itens_ingredientes_estoque_pkey");

                entity.ToTable("tbl_itens_ingredientes_estoque");

                entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");

                entity.Property(e => e.Local)
                    .HasMaxLength(20)
                    .HasColumnName("local");

                entity.Property(e => e.IdUnIngrediente).HasColumnName("id_un_ingrediente");

                entity.Property(e => e.Qtd).HasColumnName("qtd");
            });

            modelBuilder.Entity<TblItensIngredientesHistPreco>(entity =>
            {
                entity.HasKey(e => e.IdIngredienteHistPreco)
                    .HasName("tbl_itens_ingredientes_hist_precos_pkey");

                entity.ToTable("tbl_itens_ingredientes_hist_precos");

                entity.HasComment("histórico de preços dos ingredientes");

                entity.Property(e => e.IdIngredienteHistPreco)
                    .HasColumnName("id_ingrediente_hist_preco")
                    .HasDefaultValueSql("nextval('tbl_itens_ingredientes_hist_preco_id_ingrediente_hist_preco_seq'::regclass)");

                entity.Property(e => e.Custo).HasColumnName("custo");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(10)
                    .HasColumnName("unidade");
            });

            modelBuilder.Entity<TblItensIngredientesMov>(entity =>
            {
                entity.HasKey(e => e.IdIngredientesMov)
                    .HasName("tbl_itens_ingredientes_mov_pkey");

                entity.ToTable("tbl_itens_ingredientes_mov");

                entity.HasComment("movimentação de estoque dos ingredientes utilizados na cozinha, esta tabela está correlacionada com a tbl_itens_mov, uma vez que um sku teve movimentação, todos os seus ingredientes também devem ter movimentação.");

                entity.Property(e => e.IdIngredientesMov).HasColumnName("id_ingredientes_mov");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");

                entity.Property(e => e.IdItensMov).HasColumnName("id_itens_mov");

                entity.Property(e => e.Qtd)
                    .HasPrecision(8, 2)
                    .HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tipo");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("unidade")
                    .HasDefaultValueSql("'un'::character varying");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.TblItensIngredientesMovs)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_ingrediente");

                entity.HasOne(d => d.IdItensMovNavigation)
                    .WithMany(p => p.TblItensIngredientesMovs)
                    .HasForeignKey(d => d.IdItensMov)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_itens_mov");
            });

            modelBuilder.Entity<TblItensLocal>(entity =>
            {
                entity.HasKey(e => e.IdLocal)
                    .HasName("tbl_itens_categorias_pkey");

                entity.ToTable("tbl_itens_local");

                entity.HasComment("local em que o item está.\n\nSe o item não for físico, é serviço");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.Fisico)
                    .IsRequired()
                    .HasColumnName("fisico")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("local");

                entity.Property(e => e.PontoVenda).HasColumnName("ponto_venda");

                entity.Property(e => e.UsoEmpresa).HasColumnName("uso_Empresa");
            });

            modelBuilder.Entity<TblItensMov>(entity =>
            {
                entity.HasKey(e => e.IdItensMov)
                    .HasName("tbl_itens_mov_pkey");

                entity.ToTable("tbl_itens_mov");

                entity.HasComment("entradas e saídas de um determinado item\ncoluna qtd: \nentrou é positivo\nsaiu é negativo\n");

                entity.Property(e => e.IdItensMov).HasColumnName("id_itens_mov");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.IdLocal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.Qtd)
                    .HasPrecision(8, 5)
                    .HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tipo");

                entity.Property(e => e.Unidade)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("unidade")
                    .HasDefaultValueSql("'un'::character varying");
            });

            modelBuilder.Entity<TblItensMovTipo>(entity =>
            {
                entity.HasKey(e => e.IdItensMovTipo)
                    .HasName("tbl_itens_mov_tipos_pkey");

                entity.ToTable("tbl_itens_mov_tipos");

                entity.HasComment("lista os tipos de movimento de estoque, utilizados na classe Itens.cs em sua movimentação, inclusão ou baixa");

                entity.Property(e => e.IdItensMovTipo).HasColumnName("id_itens_mov_tipo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("descricao");

                entity.Property(e => e.Manual).HasColumnName("manual");
            });

            modelBuilder.Entity<TblItensMovTransferencium>(entity =>
            {
                entity.HasKey(e => e.IdItensTransf)
                    .HasName("tbl_itens_mov_transferencia_pkey");

                entity.ToTable("tbl_itens_mov_transferencia");

                entity.HasComment("histórico de transferências de um estoque para outro");

                entity.Property(e => e.IdItensTransf).HasColumnName("id_itens_transf");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("destino");

                entity.Property(e => e.Obs)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.Origem)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("origem");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.TransferidoEm)
                    .HasColumnName("transferido_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TransferidoPor)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("transferido_por");
            });

            modelBuilder.Entity<TblItensPontoCarne>(entity =>
            {
                entity.HasKey(e => e.IdPontoCarne)
                    .HasName("tbl_itens_ponto_carne_pkey");

                entity.ToTable("tbl_itens_ponto_carne");

                entity.HasComment("pontos possíveis da carne");

                entity.Property(e => e.IdPontoCarne)
                    .ValueGeneratedNever()
                    .HasColumnName("id_ponto_carne");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<TblItensRefeicao>(entity =>
            {
                entity.HasKey(e => e.IdRefeicao)
                    .HasName("tbl_itens_refeicao_pkey");

                entity.ToTable("tbl_itens_refeicao");

                entity.HasComment("tabela com os preços fixos da refeição completa e refeição kids.");

                entity.Property(e => e.IdRefeicao).HasColumnName("id_refeicao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .HasColumnName("descricao");

                entity.Property(e => e.Preco).HasColumnName("preco");
            });

            modelBuilder.Entity<TblItensUnidade>(entity =>
            {
                entity.HasKey(e => e.IdItemUn)
                    .HasName("tbl_itens_ingredientes_unidade_pkey");

                entity.ToTable("tbl_itens_unidade");

                entity.HasComment("tipos possíveis de unidade de um ingrediente");

                entity.Property(e => e.IdItemUn)
                    .ValueGeneratedNever()
                    .HasColumnName("id_item_un");

                entity.Property(e => e.Abrev)
                    .HasMaxLength(3)
                    .HasColumnName("abrev");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(10)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_log");

                entity.Property(e => e.Alteracao).HasColumnName("alteracao");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(30)
                    .HasColumnName("categoria");

                entity.Property(e => e.Datahora).HasColumnName("datahora");

                entity.Property(e => e.IdLog)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_log");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("id_usuario");
            });

            modelBuilder.Entity<TblMensagem>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("tbl_mensagem_pkey");

                entity.ToTable("tbl_mensagem");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Anexo)
                    .HasColumnType("char")
                    .HasColumnName("anexo");

                entity.Property(e => e.Arquivar)
                    .HasMaxLength(1)
                    .HasColumnName("arquivar");

                entity.Property(e => e.Assunto)
                    .HasMaxLength(50)
                    .HasColumnName("assunto");

                entity.Property(e => e.Coddest).HasColumnName("coddest");

                entity.Property(e => e.Codmensagemenv).HasColumnName("codmensagemenv");

                entity.Property(e => e.Codreme).HasColumnName("codreme");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");

                entity.Property(e => e.Encaminhada).HasColumnName("encaminhada");

                entity.Property(e => e.Encresp)
                    .HasColumnType("char")
                    .HasColumnName("encresp");

                entity.Property(e => e.Enviado)
                    .HasColumnType("char")
                    .HasColumnName("enviado");

                entity.Property(e => e.Excluido)
                    .HasColumnType("char")
                    .HasColumnName("excluido");

                entity.Property(e => e.Lida)
                    .HasMaxLength(1)
                    .HasColumnName("lida");

                entity.Property(e => e.Lixeira)
                    .HasColumnType("char")
                    .HasColumnName("lixeira");

                entity.Property(e => e.Mensagem).HasColumnName("mensagem");

                entity.Property(e => e.Novo)
                    .HasColumnType("char")
                    .HasColumnName("novo");

                entity.Property(e => e.Rascunho)
                    .HasColumnType("char")
                    .HasColumnName("rascunho");

                entity.Property(e => e.Vincmsg).HasColumnName("vincmsg");
            });

            modelBuilder.Entity<TblMensagemEnviadum>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("tbl_mensagem_enviada_pkey");

                entity.ToTable("tbl_mensagem_enviada");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Anexo)
                    .HasColumnType("char")
                    .HasColumnName("anexo");

                entity.Property(e => e.Arquivar)
                    .HasMaxLength(1)
                    .HasColumnName("arquivar");

                entity.Property(e => e.Assunto)
                    .HasMaxLength(50)
                    .HasColumnName("assunto");

                entity.Property(e => e.Coddest).HasColumnName("coddest");

                entity.Property(e => e.Codmensagemenv).HasColumnName("codmensagemenv");

                entity.Property(e => e.Codreme).HasColumnName("codreme");

                entity.Property(e => e.Data)
                    .HasColumnType("time without time zone")
                    .HasColumnName("data");

                entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");

                entity.Property(e => e.Encaminhada).HasColumnName("encaminhada");

                entity.Property(e => e.Encresp)
                    .HasColumnType("char")
                    .HasColumnName("encresp");

                entity.Property(e => e.Enviado)
                    .HasColumnType("char")
                    .HasColumnName("enviado");

                entity.Property(e => e.Excluido)
                    .HasColumnType("char")
                    .HasColumnName("excluido");

                entity.Property(e => e.Lida)
                    .HasMaxLength(1)
                    .HasColumnName("lida");

                entity.Property(e => e.Lixeira)
                    .HasColumnType("char")
                    .HasColumnName("lixeira");

                entity.Property(e => e.Mensagem).HasColumnName("mensagem");

                entity.Property(e => e.Novo)
                    .HasColumnType("char")
                    .HasColumnName("novo");

                entity.Property(e => e.Rascunho)
                    .HasColumnType("char")
                    .HasColumnName("rascunho");

                entity.Property(e => e.Vincmsg).HasColumnName("vincmsg");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_menu");

                entity.Property(e => e.Botao).HasColumnName("botao");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Codusuario).HasColumnName("codusuario");

                entity.Property(e => e.Formulario)
                    .HasMaxLength(60)
                    .HasColumnName("formulario");

                entity.Property(e => e.Legenda).HasColumnName("legenda");
            });

            modelBuilder.Entity<TblNfEntradaItem>(entity =>
            {
                entity.ToTable("tbl_nf_entrada_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cest).HasColumnName("cest");

                entity.Property(e => e.Cfop).HasColumnName("cfop");

                entity.Property(e => e.CodigoProduto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("codigo_produto");

                entity.Property(e => e.CofinsBc)
                    .HasPrecision(9, 2)
                    .HasColumnName("cofins_bc");

                entity.Property(e => e.CofinsCst).HasColumnName("cofins_cst");

                entity.Property(e => e.CofinsP)
                    .HasPrecision(9, 2)
                    .HasColumnName("cofins_p");

                entity.Property(e => e.CofinsV)
                    .HasPrecision(9, 2)
                    .HasColumnName("cofins_v");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("descricao");

                entity.Property(e => e.Ean)
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.Frete)
                    .HasPrecision(9, 2)
                    .HasColumnName("frete");

                entity.Property(e => e.IcmsCsosn).HasColumnName("icms_csosn");

                entity.Property(e => e.IcmsCst).HasColumnName("icms_cst");

                entity.Property(e => e.IcmsModbc).HasColumnName("icms_modbc");

                entity.Property(e => e.IcmsOrig).HasColumnName("icms_orig");

                entity.Property(e => e.IcmsP)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_p");

                entity.Property(e => e.IcmsPicmsefet)
                    .HasPrecision(9, 4)
                    .HasColumnName("icms_picmsefet");

                entity.Property(e => e.IcmsPredbcefet)
                    .HasPrecision(9, 4)
                    .HasColumnName("icms_predbcefet");

                entity.Property(e => e.IcmsPst)
                    .HasPrecision(9, 4)
                    .HasColumnName("icms_pst");

                entity.Property(e => e.IcmsRedbc)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_redbc");

                entity.Property(e => e.IcmsV)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_v");

                entity.Property(e => e.IcmsVbc)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vbc");

                entity.Property(e => e.IcmsVbcefet)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vbcefet");

                entity.Property(e => e.IcmsVbcstdest)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vbcstdest");

                entity.Property(e => e.IcmsVbcstret)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vbcstret");

                entity.Property(e => e.IcmsVicmsefet)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vicmsefet");

                entity.Property(e => e.IcmsVicmsstdest)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vicmsstdest");

                entity.Property(e => e.IcmsVicmsstret)
                    .HasPrecision(9, 2)
                    .HasColumnName("icms_vicmsstret");

                entity.Property(e => e.IiDespadu)
                    .HasPrecision(9, 2)
                    .HasColumnName("ii_despadu");

                entity.Property(e => e.IiVbc)
                    .HasPrecision(9, 2)
                    .HasColumnName("ii_vbc");

                entity.Property(e => e.IiVii)
                    .HasPrecision(9, 2)
                    .HasColumnName("ii_vii");

                entity.Property(e => e.IiViof)
                    .HasPrecision(9, 2)
                    .HasColumnName("ii_viof");

                entity.Property(e => e.IndTot).HasColumnName("ind_tot");

                entity.Property(e => e.IpiCenq).HasColumnName("ipi_cenq");

                entity.Property(e => e.IpiCst).HasColumnName("ipi_cst");

                entity.Property(e => e.IpiP)
                    .HasPrecision(9, 2)
                    .HasColumnName("ipi_p");

                entity.Property(e => e.IpiV)
                    .HasPrecision(9, 2)
                    .HasColumnName("ipi_v");

                entity.Property(e => e.IpiVbc)
                    .HasPrecision(9, 2)
                    .HasColumnName("ipi_vbc");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Ncm).HasColumnName("ncm");

                entity.Property(e => e.NfEntradaId).HasColumnName("nf_entrada_id");

                entity.Property(e => e.PisBc)
                    .HasPrecision(9, 2)
                    .HasColumnName("pis_bc");

                entity.Property(e => e.PisCst).HasColumnName("pis_cst");

                entity.Property(e => e.PisP)
                    .HasPrecision(9, 2)
                    .HasColumnName("pis_p");

                entity.Property(e => e.PisV)
                    .HasPrecision(9, 2)
                    .HasColumnName("pis_v");

                entity.Property(e => e.QtdPorUnComercial)
                    .HasPrecision(9, 3)
                    .HasColumnName("qtd_por_un_comercial")
                    .HasComment("quantidade de um item por unidade comercial. Por exemplo: Se compramos 10 fardos de refrigerante e cada fardo tem 6 unidades de lata, a quantiade de 6 deve ser abastecida aqui.");

                entity.Property(e => e.QuantidadeComercial)
                    .HasPrecision(9, 3)
                    .HasColumnName("quantidade_comercial");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.TotalCompradoUn)
                    .HasPrecision(9, 3)
                    .HasColumnName("total_comprado_un");

                entity.Property(e => e.TotalTributo)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_tributo");

                entity.Property(e => e.UnidadeComercial)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("unidade_comercial");

                entity.Property(e => e.ValorTotal)
                    .HasPrecision(9, 2)
                    .HasColumnName("valor_total");

                entity.Property(e => e.ValorUnitario)
                    .HasPrecision(9, 2)
                    .HasColumnName("valor_unitario");

                entity.Property(e => e.VinculadoEm).HasColumnName("vinculado_em");

                entity.Property(e => e.VinculadoPor).HasColumnName("vinculado_por");

                entity.HasOne(d => d.ItemNavigation)
                    .WithMany(p => p.TblNfEntradaItems)
                    .HasForeignKey(d => d.Item)
                    .HasConstraintName("fk_item");

                entity.HasOne(d => d.NfEntrada)
                    .WithMany(p => p.TblNfEntradaItems)
                    .HasForeignKey(d => d.NfEntradaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbl_nf_entrada_item");
            });

            modelBuilder.Entity<TblNfEntradum>(entity =>
            {
                entity.HasKey(e => e.IdNfEntrada)
                    .HasName("tbl_nf_entrada_pkey");

                entity.ToTable("tbl_nf_entrada");

                entity.Property(e => e.IdNfEntrada).HasColumnName("id_nf_entrada");

                entity.Property(e => e.Cdv).HasColumnName("cdv");

                entity.Property(e => e.ChaveAcesso)
                    .IsRequired()
                    .HasMaxLength(44)
                    .HasColumnName("chave_acesso");

                entity.Property(e => e.Cmunfg).HasColumnName("cmunfg");

                entity.Property(e => e.Cnf).HasColumnName("cnf");

                entity.Property(e => e.CnpjEmitente)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("cnpj_emitente");

                entity.Property(e => e.CodigoUsuario).HasColumnName("codigo_usuario");

                entity.Property(e => e.Cstat).HasColumnName("cstat");

                entity.Property(e => e.Cuf).HasColumnName("cuf");

                entity.Property(e => e.DataEmissao)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("data_emissao");

                entity.Property(e => e.DataRecebido)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("data_recebido")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DataRegistro)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("data_registro");

                entity.Property(e => e.Finnfe).HasColumnName("finnfe");

                entity.Property(e => e.Iddest).HasColumnName("iddest");

                entity.Property(e => e.Indfinal).HasColumnName("indfinal");

                entity.Property(e => e.Indintermed).HasColumnName("indintermed");

                entity.Property(e => e.Indpres).HasColumnName("indpres");

                entity.Property(e => e.Mod).HasColumnName("mod");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasDefaultValueSql("''::text");

                entity.Property(e => e.Natop)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("natop")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Nprot)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("nprot")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.NumeroNota).HasColumnName("numero_nota");

                entity.Property(e => e.Procemi).HasColumnName("procemi");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.TotalBcst)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_bcst");

                entity.Property(e => e.TotalCofins)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_cofins");

                entity.Property(e => e.TotalDesc)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_desc");

                entity.Property(e => e.TotalFcp)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_fcp");

                entity.Property(e => e.TotalFcpst)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_fcpst");

                entity.Property(e => e.TotalFcpufdest)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_fcpufdest");

                entity.Property(e => e.TotalFrete)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_frete");

                entity.Property(e => e.TotalIcms)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_icms");

                entity.Property(e => e.TotalIcmsdeson)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_icmsdeson");

                entity.Property(e => e.TotalIcmsufdest)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_icmsufdest");

                entity.Property(e => e.TotalIcmsufremet)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_icmsufremet");

                entity.Property(e => e.TotalIi)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_ii");

                entity.Property(e => e.TotalIpi)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_ipi");

                entity.Property(e => e.TotalIpidevol)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_ipidevol");

                entity.Property(e => e.TotalOutro)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_outro");

                entity.Property(e => e.TotalPis)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_pis");

                entity.Property(e => e.TotalSeg)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_seg");

                entity.Property(e => e.TotalSt)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_st");

                entity.Property(e => e.TotalVbc)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_vbc");

                entity.Property(e => e.Tpamb).HasColumnName("tpamb");

                entity.Property(e => e.Tpemis).HasColumnName("tpemis");

                entity.Property(e => e.Tpimp).HasColumnName("tpimp");

                entity.Property(e => e.Tpnf).HasColumnName("tpnf");

                entity.Property(e => e.ValorTotalItem)
                    .HasPrecision(9, 2)
                    .HasColumnName("valor_total_item");

                entity.Property(e => e.ValorTotalNf)
                    .HasPrecision(9, 2)
                    .HasColumnName("valor_total_nf");

                entity.Property(e => e.Verproc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("verproc")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasColumnName("xml");

                entity.HasOne(d => d.CnpjEmitenteNavigation)
                    .WithMany(p => p.TblNfEntrada)
                    .HasForeignKey(d => d.CnpjEmitente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornecedor");
            });

            modelBuilder.Entity<TblOcorrChamado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("tbl_ocorr_chamados_pkey");

                entity.ToTable("tbl_ocorr_chamados");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Anotacao).HasColumnName("anotacao");

                entity.Property(e => e.Codassistencia)
                    .HasColumnName("codassistencia")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");

                entity.Property(e => e.Codtiposervico).HasColumnName("codtiposervico");

                entity.Property(e => e.Datachamado)
                    .HasPrecision(2)
                    .HasColumnName("datachamado");

                entity.Property(e => e.Dataencerrado)
                    .HasPrecision(2)
                    .HasColumnName("dataencerrado");

                entity.Property(e => e.Dataexecucao)
                    .HasColumnType("date")
                    .HasColumnName("dataexecucao");

                entity.Property(e => e.MetodoReferencia)
                    .HasColumnType("character varying")
                    .HasColumnName("metodo_referencia");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Obsfechamento).HasColumnName("obsfechamento");

                entity.Property(e => e.Origem)
                    .HasColumnType("char")
                    .HasColumnName("origem");

                entity.Property(e => e.Patrimonio).HasColumnName("patrimonio");

                entity.Property(e => e.Planejamento)
                    .HasColumnName("planejamento")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Previsao)
                    .HasPrecision(0)
                    .HasColumnName("previsao");

                entity.Property(e => e.Prioridade)
                    .HasColumnName("prioridade")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Ramal).HasColumnName("ramal");

                entity.Property(e => e.Recebido)
                    .HasColumnName("recebido")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Retornoassistencia)
                    .HasPrecision(0)
                    .HasColumnName("retornoassistencia");

                entity.Property(e => e.UserPrioridade).HasColumnName("user_prioridade");

                entity.Property(e => e.Useracompanha).HasColumnName("useracompanha");

                entity.Property(e => e.Userchamado).HasColumnName("userchamado");

                entity.Property(e => e.Userexecuta).HasColumnName("userexecuta");
            });

            modelBuilder.Entity<TblOcorrChamadosReag>(entity =>
            {
                entity.HasKey(e => e.CodReag)
                    .HasName("tbl_ocorr_chamados_reag_pkey");

                entity.ToTable("tbl_ocorr_chamados_reag");

                entity.Property(e => e.CodReag).HasColumnName("cod_reag");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAntiga)
                    .HasPrecision(2)
                    .HasColumnName("data_antiga");

                entity.Property(e => e.DataNova)
                    .HasPrecision(2)
                    .HasColumnName("data_nova");

                entity.Property(e => e.DataReag)
                    .HasPrecision(2)
                    .HasColumnName("data_reag");

                entity.Property(e => e.Reaberto).HasColumnName("reaberto");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<TblOcorrServico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("tbl_ocorr_servico_pkey");

                entity.ToTable("tbl_ocorr_servico");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<TblOcorrUsuario>(entity =>
            {
                entity.HasKey(e => e.Codusuario)
                    .HasName("tbl_ocorr_usuarios_pkey");

                entity.ToTable("tbl_ocorr_usuarios");

                entity.Property(e => e.Codusuario)
                    .ValueGeneratedNever()
                    .HasColumnName("codusuario");
            });

            modelBuilder.Entity<TblPagamento>(entity =>
            {
                entity.HasKey(e => e.IdPagamento);

                entity.ToTable("tbl_pagamentos");

                entity.HasIndex(e => e.IdFluxo, "IX_tbl_pagamentos_id_caixa");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.Property(e => e.Acrescimo)
                    .HasPrecision(14, 2)
                    .HasColumnName("acrescimo");

                entity.Property(e => e.DataPagamento).HasColumnName("data_pagamento");

                entity.Property(e => e.Desconto)
                    .HasPrecision(14, 2)
                    .HasColumnName("desconto");

                entity.Property(e => e.Estornado).HasColumnName("estornado");

                entity.Property(e => e.EstornadoEm).HasColumnName("estornado_em");

                entity.Property(e => e.EstornadoPor).HasColumnName("estornado_por");

                entity.Property(e => e.EstornoObs)
                    .HasMaxLength(200)
                    .HasColumnName("estorno_obs");

                entity.Property(e => e.IdFluxo).HasColumnName("id_fluxo");

                entity.Property(e => e.IdPedidoCompra).HasColumnName("id_pedido_compra");

                entity.Property(e => e.LancadoEm).HasColumnName("lancado_em");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.Liquidado).HasColumnName("liquidado");

                entity.Property(e => e.ObsPagamento)
                    .HasMaxLength(200)
                    .HasColumnName("obs_pagamento");

                entity.Property(e => e.Pago).HasColumnName("pago");

                entity.Property(e => e.PagoPor).HasColumnName("pago_por");

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.QtdParcelas).HasColumnName("qtd_parcelas");

                entity.Property(e => e.TipoPagamento)
                    .HasMaxLength(30)
                    .HasColumnName("tipo_pagamento");

                entity.Property(e => e.ValorPago)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor_pago");

                entity.Property(e => e.ValorParcela)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor_parcela");

                entity.Property(e => e.ValorTotal)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor_total");

                entity.Property(e => e.Vencimento).HasColumnName("vencimento");
            });

            modelBuilder.Entity<TblPagamentosLogVencimentoAlterado>(entity =>
            {
                entity.HasKey(e => e.IdPagamentoLogVencAlterado)
                    .HasName("tbl_pagamentos_log_vencimento_alterado_pkey");

                entity.ToTable("tbl_pagamentos_log_vencimento_alterado");

                entity.Property(e => e.IdPagamentoLogVencAlterado)
                    .HasColumnName("id_pagamento_log_venc_alterado")
                    .HasDefaultValueSql("nextval('tbl_pagamentos_log_vencimento_id_pagamento_log_venc_alterad_seq'::regclass)");

                entity.Property(e => e.AlteradoEm)
                    .HasColumnName("alterado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.AlteradoPor).HasColumnName("alterado_por");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.Property(e => e.VencimentoDestino).HasColumnName("vencimento_destino");

                entity.Property(e => e.VencimentoOrigem).HasColumnName("vencimento_origem");
            });

            modelBuilder.Entity<TblPagamentosTipo>(entity =>
            {
                entity.HasKey(e => e.IdPagamentoTipo)
                    .HasName("PK_tbl_pagamento_tipo");

                entity.ToTable("tbl_pagamentos_tipos");

                entity.Property(e => e.IdPagamentoTipo).HasColumnName("id_pagamento_tipo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descricao");

                entity.Property(e => e.LiquidadoNoPag)
                    .IsRequired()
                    .HasColumnName("liquidado_no_pag")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TransfForma).HasColumnName("transf_forma");
            });

            modelBuilder.Entity<TblPedidoCompra>(entity =>
            {
                entity.HasKey(e => e.IdPedidoCompra)
                    .HasName("tbl_pedido_compra_pkey");

                entity.ToTable("tbl_pedido_compra");

                entity.Property(e => e.IdPedidoCompra).HasColumnName("id_pedido_compra");

                entity.Property(e => e.AtualizadoEm).HasColumnName("atualizado_em");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.CnpjFornecedor)
                    .HasMaxLength(14)
                    .HasColumnName("cnpj_fornecedor");

                entity.Property(e => e.Comprador)
                    .HasMaxLength(50)
                    .HasColumnName("comprador");

                entity.Property(e => e.CriadoEm)
                    .HasColumnName("criado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CriadoPor).HasColumnName("criado_por");

                entity.Property(e => e.DataEntrega).HasColumnName("data_entrega");

                entity.Property(e => e.Desconto)
                    .HasPrecision(10, 2)
                    .HasColumnName("desconto");

                entity.Property(e => e.GeracaoManual).HasColumnName("geracao_manual");

                entity.Property(e => e.GeradoPorNf).HasColumnName("gerado_por_nf");

                entity.Property(e => e.IdDivPrinc).HasColumnName("id_div_princ");

                entity.Property(e => e.IdDivSecun).HasColumnName("id_div_secun");

                entity.Property(e => e.IdDivTerc).HasColumnName("id_div_terc");

                entity.Property(e => e.IdEntrega).HasColumnName("id_entrega");

                entity.Property(e => e.IdNfEntrada)
                    .HasMaxLength(50)
                    .HasColumnName("id_nf_entrada");

                entity.Property(e => e.IncompletoNf).HasColumnName("incompleto_nf");

                entity.Property(e => e.Observacao).HasColumnName("observacao");

                entity.Property(e => e.TipoEntrega)
                    .HasMaxLength(10)
                    .HasColumnName("tipo_entrega");

                entity.Property(e => e.TipoPedido)
                    .HasMaxLength(50)
                    .HasColumnName("tipo_pedido")
                    .HasComment("conforme tabela tbl_financeiro_div_princ");

                entity.Property(e => e.ValorFrete)
                    .HasPrecision(10, 2)
                    .HasColumnName("valor_frete");

                entity.Property(e => e.ValorTotalPedido)
                    .HasPrecision(10, 2)
                    .HasColumnName("valor_total_pedido");
            });

            modelBuilder.Entity<TblPedidoCompraSub>(entity =>
            {
                entity.HasKey(e => e.IdPedidoCompraSub)
                    .HasName("tbl_pedido_compra_sub_pkey");

                entity.ToTable("tbl_pedido_compra_sub");

                entity.HasComment("detalhes adicionais do pedido de compra, com dados das despesas, investimentos, emprestimos ");

                entity.Property(e => e.IdPedidoCompraSub).HasColumnName("id_pedido_compra_sub");

                entity.Property(e => e.ComNota).HasColumnName("com_nota");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.Ean)
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.IdPedidoCompra).HasColumnName("id_pedido_compra");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor).HasColumnName("lancado_por");

                entity.Property(e => e.Ncm).HasColumnName("ncm");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.ValorTotal)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor_total");

                entity.Property(e => e.ValorUnit)
                    .HasPrecision(14, 2)
                    .HasColumnName("valor_unit");
            });

            modelBuilder.Entity<TblPermisso>(entity =>
            {
                entity.HasKey(e => e.IdPermissao)
                    .HasName("tbl_permissao_pkey");

                entity.ToTable("tbl_permissoes");

                entity.HasComment("tabela com permissoes especiais de acesso do sistema");

                entity.Property(e => e.IdPermissao)
                    .HasColumnName("id_permissao")
                    .HasDefaultValueSql("nextval('tbl_permissao_id_permissao_seq'::regclass)");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Permitido).HasColumnName("permitido");
            });

            modelBuilder.Entity<TblPermissoesAcessosFuncao>(entity =>
            {
                entity.HasKey(e => e.IdAcessoFuncao)
                    .HasName("tbl_permissoes_acessos_funcao_pkey");

                entity.ToTable("tbl_permissoes_acessos_funcao");

                entity.HasComment("acessos por função de cada tela");

                entity.Property(e => e.IdAcessoFuncao).HasColumnName("id_acesso_funcao");

                entity.Property(e => e.AtualizadoEm).HasColumnName("atualizado_em");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.IdAcesso).HasColumnName("id_acesso");

                entity.Property(e => e.IdFuncao).HasColumnName("id_funcao");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor)
                    .HasColumnName("lancado_por")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Permitido).HasColumnName("permitido");
            });

            modelBuilder.Entity<TblPermissoesAcessosMenu>(entity =>
            {
                entity.HasKey(e => e.IdAcesso)
                    .HasName("tbl_permissoes_acessos_pkey");

                entity.ToTable("tbl_permissoes_acessos_menu");

                entity.HasComment("tela com os acessos da WpfPrincipal");

                entity.Property(e => e.IdAcesso)
                    .HasColumnName("id_acesso")
                    .HasDefaultValueSql("nextval('tbl_permissoes_acessos_id_acesso_seq'::regclass)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("descricao");

                entity.Property(e => e.NomeAcesso)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nome_acesso");
            });

            modelBuilder.Entity<TblPermissoesAcessosUsuario>(entity =>
            {
                entity.HasKey(e => e.IdAcessoUsuario)
                    .HasName("tbl_permissoes_acessos_usuario_pkey");

                entity.ToTable("tbl_permissoes_acessos_usuario");

                entity.Property(e => e.IdAcessoUsuario).HasColumnName("id_acesso_usuario");

                entity.Property(e => e.AtualizadoEm)
                    .HasColumnName("atualizado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.AtualizadoPor).HasColumnName("atualizado_por");

                entity.Property(e => e.IdAcesso).HasColumnName("id_acesso");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.LancadoEm)
                    .HasColumnName("lancado_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LancadoPor)
                    .HasColumnName("lancado_por")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Permitido).HasColumnName("permitido");
            });

            modelBuilder.Entity<TblPermissoesForm>(entity =>
            {
                entity.HasKey(e => e.IdPermissaoForm)
                    .HasName("tbl_permissoes_form_pkey");

                entity.ToTable("tbl_permissoes_form");

                entity.HasComment("permissão por usuário com o nome da form");

                entity.Property(e => e.IdPermissaoForm).HasColumnName("id_permissao_form");

                entity.Property(e => e.ConcedidaEm)
                    .HasColumnName("concedida_em")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ConcedidaPor).HasColumnName("concedida_por");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("form");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<TblPesquisaHospede>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Documento })
                    .HasName("tbl_pesquisa_hospedes_pkey");

                entity.ToTable("tbl_pesquisa_hospedes");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Documento)
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.ArrumacaoAcomodacao).HasColumnName("arrumacao_acomodacao");

                entity.Property(e => e.AtendimentoBar).HasColumnName("atendimento_bar");

                entity.Property(e => e.AtendimentoMonitoria).HasColumnName("atendimento_monitoria");

                entity.Property(e => e.AtendimentoRecepcao).HasColumnName("atendimento_recepcao");

                entity.Property(e => e.AtendimentoReservaAntecipada).HasColumnName("atendimento_reserva_antecipada");

                entity.Property(e => e.AtendimentoRestaurante).HasColumnName("atendimento_restaurante");

                entity.Property(e => e.CafeDaManha).HasColumnName("cafe_da_manha");

                entity.Property(e => e.ComentariosSugestões)
                    .HasMaxLength(300)
                    .HasColumnName("comentarios_sugestões");

                entity.Property(e => e.ComoNosConheceu)
                    .HasMaxLength(50)
                    .HasColumnName("como_nos_conheceu");

                entity.Property(e => e.ConexaoDeInternet).HasColumnName("conexao_de_internet");

                entity.Property(e => e.ConservacaoDaEmpresa).HasColumnName("conservacao_da_Empresa");

                entity.Property(e => e.Data)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("data");

                entity.Property(e => e.GostariaDeVer)
                    .HasMaxLength(300)
                    .HasColumnName("gostaria_de_ver");

                entity.Property(e => e.IndiceDeSatisfacao)
                    .HasColumnType("character varying")
                    .HasColumnName("indice_de_satisfacao");

                entity.Property(e => e.Limpeza).HasColumnName("limpeza");

                entity.Property(e => e.Loginuser)
                    .HasColumnType("character varying")
                    .HasColumnName("loginuser");

                entity.Property(e => e.ProcuraNaEmpresa)
                    .HasColumnType("character varying")
                    .HasColumnName("procura_na_Empresa");

                entity.Property(e => e.Refeicao).HasColumnName("refeicao");
            });

            modelBuilder.Entity<TblEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("tbl_Empresas_pkey");

                entity.ToTable("tbl_Empresas");

                entity.HasComment("dados das Empresas");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_Empresa");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(25)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .HasColumnName("cidade");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(30)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(300)
                    .HasColumnName("endereco");

                entity.Property(e => e.Ie)
                    .HasMaxLength(30)
                    .HasColumnName("ie");

                entity.Property(e => e.NomeEmpresarial)
                    .HasMaxLength(200)
                    .HasColumnName("nome_empresarial");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(200)
                    .HasColumnName("nome_fantasia");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("uf");
            });

            modelBuilder.Entity<TblRecebimento>(entity =>
            {
                entity.HasKey(e => e.IdRecebimento);

                entity.ToTable("tbl_recebimentos");

                entity.HasIndex(e => e.IdCaixa, "IX_tbl_recebimentos_id_caixa");

                entity.HasIndex(e => e.Forma, "IX_tbl_recebimentos_id_forma_pagamento");

                entity.HasIndex(e => e.IdUsuario, "IX_tbl_recebimentos_id_usuario");

                entity.Property(e => e.IdRecebimento).HasColumnName("id_recebimento");

                entity.Property(e => e.DataPagamento).HasColumnName("data_pagamento");

                entity.Property(e => e.Desconto).HasColumnName("desconto");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("documento");

                entity.Property(e => e.Forma)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("forma");

                entity.Property(e => e.IdCaixa)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("id_caixa");

                entity.Property(e => e.IdConsumoFechado).HasColumnName("id_consumo_fechado");

                entity.Property(e => e.IdHospede).HasColumnName("id_hospede");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Juros).HasColumnName("juros");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.Pago).HasColumnName("pago");

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.QtdParcelas).HasColumnName("qtd_parcelas");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tipo");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.ValorPago).HasColumnName("valor_pago");

                entity.Property(e => e.Vencimento).HasColumnName("vencimento");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TblRecebimentos)
                    .HasForeignKey(d => d.IdUsuario);
            });

            modelBuilder.Entity<TblReserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);

                entity.ToTable("tbl_reservas");

                entity.HasIndex(e => e.Vendedor, "IX_tbl_reservas_vendedor");

                entity.Property(e => e.IdReserva).HasColumnName("id_reserva");

                entity.Property(e => e.Adultos)
                    .HasMaxLength(80)
                    .HasColumnName("adultos")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.AtualizadoPor)
                    .HasMaxLength(30)
                    .HasColumnName("atualizado_por");

                entity.Property(e => e.CriadoPor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("criado_por")
                    .HasDefaultValueSql("'Cloudbeds'::character varying");

                entity.Property(e => e.Criancas)
                    .HasMaxLength(80)
                    .HasColumnName("criancas")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnName("data_atualizacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("data_criacao")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataFinal).HasColumnName("data_final");

                entity.Property(e => e.DataInicio).HasColumnName("data_inicio");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Fonte)
                    .HasMaxLength(60)
                    .HasColumnName("fonte")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdHospede)
                    .HasMaxLength(80)
                    .HasColumnName("id_hospede");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_hospede_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdPensao)
                    .HasColumnName("id_pensao")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdReservaCb)
                    .HasMaxLength(80)
                    .HasColumnName("id_reserva_cb");

                entity.Property(e => e.ItensAdicionaisBalanco).HasColumnName("itens_adicionais_balanco");

                entity.Property(e => e.NomeHospede)
                    .HasMaxLength(60)
                    .HasColumnName("nome_hospede")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeQuarto)
                    .HasMaxLength(60)
                    .HasColumnName("nome_quarto")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Ota).HasColumnName("ota");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'empty'::character varying")
                    .HasComment("quando é alterado status do cliente, é alterado aqui");

                entity.Property(e => e.StatusHospede)
                    .HasMaxLength(50)
                    .HasColumnName("status_hospede")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Total)
                    .HasPrecision(13, 2)
                    .HasColumnName("total");

                entity.Property(e => e.TotalQuarto)
                    .HasMaxLength(80)
                    .HasColumnName("total_quarto")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("vendedor")
                    .HasDefaultValueSql("4");

                entity.HasOne(d => d.VendedorNavigation)
                    .WithMany(p => p.TblReservas)
                    .HasForeignKey(d => d.Vendedor)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TblReservasComissaoAlq>(entity =>
            {
                entity.ToTable("tbl_reservas_comissao_alq");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comissao)
                    .HasPrecision(14, 2)
                    .HasColumnName("comissao");

                entity.Property(e => e.Tipo)
                    .HasColumnType("character varying")
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TblReservasComissaoHistAutorizacao>(entity =>
            {
                entity.HasKey(e => e.IdComissaoHistAuto)
                    .HasName("tbl_reservas_comissao_hist_autorizacao_pkey");

                entity.ToTable("tbl_reservas_comissao_hist_autorizacao");

                entity.Property(e => e.IdComissaoHistAuto)
                    .HasColumnName("id_comissao_hist_auto")
                    .HasDefaultValueSql("nextval('tbl_reservas_comissao_hist_autorizaca_id_comissao_hist_auto_seq'::regclass)");

                entity.Property(e => e.AutorizadoEm).HasColumnName("autorizado_em");

                entity.Property(e => e.IdReservaCb)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("id_reserva_cb");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Obs)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("obs");

                entity.Property(e => e.ValorCb).HasColumnName("valor_cb");

                entity.Property(e => e.ValorSistema).HasColumnName("valor_sistema");
            });

            modelBuilder.Entity<TblReservasFonte>(entity =>
            {
                entity.HasKey(e => e.IdReservaFonte)
                    .HasName("tbl_reservas_fonte_pkey");

                entity.ToTable("tbl_reservas_fonte");

                entity.Property(e => e.IdReservaFonte).HasColumnName("id_reserva_fonte");

                entity.Property(e => e.Fonte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fonte");
            });

            modelBuilder.Entity<TblReservasHospede>(entity =>
            {
                entity.HasKey(e => new { e.IdReserva, e.IdHospede })
                    .HasName("tbl_reservas_hospedes_pkey");

                entity.ToTable("tbl_reservas_hospedes");

                entity.Property(e => e.IdReserva)
                    .HasMaxLength(80)
                    .HasColumnName("id_reserva");

                entity.Property(e => e.IdHospede).HasColumnName("id_hospede");
            });

            modelBuilder.Entity<TblReservasPensao>(entity =>
            {
                entity.HasKey(e => e.IdPensao)
                    .HasName("tbl_reservas_pensao_pkey");

                entity.ToTable("tbl_reservas_pensao");

                entity.Property(e => e.IdPensao).HasColumnName("id_pensao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descricao");

                entity.Property(e => e.RefeicoesDiarias).HasColumnName("refeicoes_diarias");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TblReservasStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("tbl_reservas_status_pkey");

                entity.ToTable("tbl_reservas_status");

                entity.HasComment("tipos de status de reserva");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_status");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("descricao");

                entity.Property(e => e.DescricaoCb)
                    .HasMaxLength(50)
                    .HasColumnName("descricao_cb");
            });

            modelBuilder.Entity<TblSessoesUsuario>(entity =>
            {
                entity.HasKey(e => e.IdSessao);

                entity.ToTable("tbl_sessoes_usuario");

                entity.HasIndex(e => e.IdUsuario, "IX_tbl_sessoes_usuario_id_usuario");

                entity.Property(e => e.IdSessao).HasColumnName("id_sessao");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TblSessoesUsuarios)
                    .HasForeignKey(d => d.IdUsuario);
            });

            modelBuilder.Entity<TblSuite>(entity =>
            {
                entity.HasKey(e => e.IdSuite);

                entity.ToTable("tbl_suites");

                entity.Property(e => e.IdSuite).HasColumnName("id_suite");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("abreviatura");

                entity.Property(e => e.Acomodacao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("acomodacao");

                entity.Property(e => e.Instalacoes)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("instalacoes");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<TblTransaco>(entity =>
            {
                entity.HasKey(e => e.IdTransacao);

                entity.ToTable("tbl_transacoes");

                entity.HasIndex(e => e.Vendedor, "IX_tbl_transacoes_vendedor");

                entity.Property(e => e.IdTransacao).HasColumnName("id_transacao");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(40)
                    .HasColumnName("categoria")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(180)
                    .HasColumnName("descricao")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Excluido).HasColumnName("excluido");

                entity.Property(e => e.ExcluidoEm).HasColumnName("excluido_em");

                entity.Property(e => e.ExcluidoPor).HasColumnName("excluido_por");

                entity.Property(e => e.IdDivTerc).HasColumnName("id_div_terc");

                entity.Property(e => e.IdHospedeCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_hospede_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.IdReservaCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_reserva_cb")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.IdTransacaoCb)
                    .HasMaxLength(120)
                    .HasColumnName("id_transacao_cb");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(80)
                    .HasColumnName("nome_cliente")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeQuarto)
                    .HasMaxLength(60)
                    .HasColumnName("nome_quarto")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.NomeUsuario)
                    .HasMaxLength(60)
                    .HasColumnName("nome_usuario")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Notas)
                    .HasMaxLength(200)
                    .HasColumnName("notas")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Sku)
                    .HasMaxLength(10)
                    .HasColumnName("sku");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("'empty'::character varying");

                entity.Property(e => e.Valor)
                    .HasPrecision(13, 2)
                    .HasColumnName("valor");

                entity.Property(e => e.Vendedor).HasColumnName("vendedor");
            });

            modelBuilder.Entity<TblTransacoesPasseio>(entity =>
            {
                entity.HasKey(e => e.IdPasseio);

                entity.ToTable("tbl_transacoes_passeios");

                entity.Property(e => e.IdPasseio).HasColumnName("id_passeio");

                entity.Property(e => e.DescricaoTransacao)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("descricao_transacao");

                entity.Property(e => e.Parceiro)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("parceiro");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("tbl_usuarios");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Alterarsenha).HasColumnName("alterarsenha");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .HasColumnName("cpf");

                entity.Property(e => e.CriadoPor)
                    .HasMaxLength(50)
                    .HasColumnName("criado_por");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("data_cadastro")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email");

                entity.Property(e => e.IdFuncao).HasColumnName("id_funcao");

                entity.Property(e => e.IdLocal)
                    .HasMaxLength(10)
                    .HasColumnName("id_local");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("nome");

                entity.Property(e => e.Password)
                    .HasMaxLength(80)
                    .HasColumnName("password");

                entity.Property(e => e.PermissaoEspecial).HasColumnName("permissao_especial");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblUsuariosFuncao>(entity =>
            {
                entity.HasKey(e => e.IdFuncao);

                entity.ToTable("tbl_usuarios_funcao");

                entity.Property(e => e.IdFuncao).HasColumnName("id_funcao");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Funcao)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("funcao");

                entity.Property(e => e.LocaisTrabalho)
                    .HasMaxLength(30)
                    .HasColumnName("locais_trabalho");
            });

            modelBuilder.Entity<TblUsuariosHistoricoLogin>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoLogin)
                    .HasName("tbl_usuarios_historico_login_pkey");

                entity.ToTable("tbl_usuarios_historico_login");

                entity.HasComment("registros (histórico) do login de usuários");

                entity.Property(e => e.IdHistoricoLogin).HasColumnName("id_historico_login");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ip)
                    .HasMaxLength(300)
                    .HasColumnName("ip");

                entity.Property(e => e.NomePc)
                    .HasMaxLength(300)
                    .HasColumnName("nome_pc");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(200)
                    .HasColumnName("sistema");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            modelBuilder.HasSequence("tbl_pedido_compra_id_pedido_compra_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
