using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Estoque : ControllerBase
    {
        private readonly dbBanco _dbContext = new();

        [HttpGet]
        [Route("lista-contagens")]
        public async Task<List<TblContaEstoque>> Contagem()
        {
            try
            {
                var lista = await _dbContext.TblContaEstoques.Where(x => string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir)).OrderBy(x => x.DataAbre).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-contagem-fast")]
        public async Task<List<TblContaEstoque>> ContagemFast(string status)
        {
            try
            {
                var lista = await _dbContext.TblContaEstoques.Where(x => x.Finalizado == status && x.IdLista != null && x.Excluir == null).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-contagem-fast-id")]
        public async Task<List<TblContaEstoquePre>> ContagemFastId(int idCard)
        {
            try
            {
                var lista = await _dbContext.TblContaEstoquePres.Where(x => x.Idlista == idCard).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("historico-estoque-atual")]
        public async Task<List<SelectEstoqueAtual>> HistoricoAtual(int idCard)
        {
            try
            {
                List<SelectEstoqueAtual> atual = new List<SelectEstoqueAtual>();

                var _pre = await _dbContext.TblContaEstoquePres.Where(x => x.Idlista == idCard).ToListAsync();

                foreach (var item in _pre)
                {
                    Decimal somar = 0;

                    var move = await _dbContext.TblItensMovs.Where(x => x.Sku == item.Sku && x.IdLocal == item.Idlocal).ToListAsync();

                    for (int i = 0; i < move.Count; i++)
                    {
                        if (move[i].Sku == item.Sku && move[i].IdLocal == item.Idlocal)
                        {
                            Decimal num = Convert.ToDecimal(move[i].Qtd);
                            somar = Decimal.Add(somar, num);
                        }
                    }

                    atual.Add(new SelectEstoqueAtual
                    {
                        IdLista = item.Idlista,
                        EstoqueAtual = somar
                    });
                }

                return atual;
            }

            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("id-ultima-lista")]
        public async Task<int> UltimoId()
        {
            try
            {
                var lista = await _dbContext.TblContaEstoquePres.OrderByDescending(x => x.Idlista).FirstOrDefaultAsync();

                if (lista == null)
                {
                    return 0;
                }
                else
                {
                    return lista.Idlista;
                }
            }
            catch (Exception ex)
            {
                return 0000000;
            }
        }

        [HttpPost]
        [Route("criar-contagem")]
        public async Task<ActionResult> Criar(TblContaEstoque tblConta)
        {
            try
            {
                _dbContext.TblContaEstoques.Add(tblConta);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("criar-contagem-fast")]
        public async Task<ActionResult> CriarFast(List<TblContaEstoquePre> tblContaFast)
        {
            try
            {
                _dbContext.TblContaEstoquePres.AddRange(tblContaFast);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("att-historico")]
        public async Task<ActionResult> AtualizaHistorico(List<SelectEstoqueAtual> tbl)
        {
            try
            {
                var pre_estoque = _dbContext.TblContaEstoquePres.Where(x => x.Idlista == tbl[0].IdLista).ToList();

                if (pre_estoque != null)
                {
                    for (int i = 0; i < pre_estoque.Count; i++)
                    {
                        pre_estoque[i].EstoqueAtual = tbl[i].EstoqueAtual;
                    }

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem atualizada com sucesso");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("att-contagem")]
        public async Task<ActionResult> AtualizaContagem(int id, string local, string user)
        {
            try
            {
                var estoque = _dbContext.TblContaEstoques.FirstOrDefault(x => x.IdLista == id && string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir));
                var pre_estoque = _dbContext.TblContaEstoquePres.Where(x => x.Idlista == id && string.IsNullOrEmpty(x.Finaliza));

                if (estoque != null && pre_estoque != null)
                {
                    estoque.Finalizado = "S";
                    estoque.DataFecha = DateTime.Now;
                    estoque.UserFecha = user;
                    estoque.IdLocal = local;

                    foreach (var item in pre_estoque)
                    {
                        item.Finaliza = "S";
                    }

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem atualizada com sucesso");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("deleta-contagem")]
        public async Task<ActionResult> DeleteContagem(int id, string user)
        {
            try
            {
                var estoque = _dbContext.TblContaEstoques.FirstOrDefault(x => x.Id == id && string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir));

                if (estoque != null)
                {
                    estoque.Excluir = "S";
                    estoque.UserExcluir = user;

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem deletada com sucesso");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
