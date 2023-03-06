using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Repository.Models
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

        public virtual DbSet<ErrorLogsController> ErrorLogsControllers { get; set; }
        public virtual DbSet<TblContaEstoque> TblContaEstoques { get; set; }
        public virtual DbSet<TblContaEstoquePre> TblContaEstoquePres { get; set; }
        public virtual DbSet<TblIten> TblItens { get; set; }
        public virtual DbSet<TblItens1Categorium> TblItens1Categoria { get; set; }
        public virtual DbSet<TblItens2Grupo> TblItens2Grupos { get; set; }
        public virtual DbSet<TblItens3Subgrupo> TblItens3Subgrupos { get; set; }
        public virtual DbSet<TblItensEstoque> TblItensEstoques { get; set; }
        public virtual DbSet<TblItensLocal> TblItensLocals { get; set; }
        public virtual DbSet<TblItensMov> TblItensMovs { get; set; }
        public virtual DbSet<TblLog> TblLogs { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

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

                entity.Property(e => e.IdLocal)
                    .HasColumnType("character varying")
                    .HasColumnName("id_local");

                entity.Property(e => e.UserAbre)
                    .HasColumnType("character varying")
                    .HasColumnName("user_abre");

                entity.Property(e => e.UserExcluir)
                    .HasColumnType("character varying")
                    .HasColumnName("user_excluir");

                entity.Property(e => e.UserFecha)
                    .HasColumnType("character varying")
                    .HasColumnName("user_fecha");

                entity.Property(e => e.IdLista).HasColumnName("id_lista");

                entity.Property(e => e.IdCategoriaLista).HasColumnName("idcategorialista");

            });

            modelBuilder.Entity<TblContaEstoquePre>(entity =>
            {
                entity.ToTable("tbl_conta_estoque_pre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datasave).HasColumnName("datasave");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.Property(e => e.Iditem).HasColumnName("iditem");

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

                entity.Property(e => e.Idlista).HasColumnName("idlista");

                entity.Property(e => e.Finaliza).HasMaxLength(1).HasColumnType("character varying").HasColumnName("finaliza");

                entity.Property(e => e.EstoqueAtual).HasColumnName("estoqueatual");

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

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .HasColumnName("username");
            });

            modelBuilder.HasSequence("tbl_pedido_compra_id_pedido_compra_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
