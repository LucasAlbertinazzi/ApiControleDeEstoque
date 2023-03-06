using Microsoft.AspNetCore.Mvc;
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
    public class Itens : ControllerBase
    {
        private readonly dbBanco _dbContext = new();

        //GET api/<itens-id-local>
        [HttpGet]
        public async Task<List<TblIten>> GruposIdCat()
        {
            var itens = await _dbContext.TblItens.Where(x => x.Ativo == true && x.IdCategoria == 1 || x.IdCategoria == 2 || x.IdCategoria == 7).OrderBy(p => p.Descricao).ToListAsync();

            if (itens == null)
            {
                return null;
            }

            else
            {
                return itens;
            }
        }

        [HttpGet]
        [Route("itens-id")]
        public async Task<List<TblIten>> ItensId(int id)
        {
            try
            {
                var lista = await _dbContext.TblItens.Where(x => x.IdItem == id).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
