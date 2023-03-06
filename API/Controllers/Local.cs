using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Local : ControllerBase
    {
        private readonly dbBanco _dbContext = new();

        //GET api/<lista-local-pelo-id>
        [HttpGet]
        public async Task<List<TblItensLocal>> Local_id(string id_local)
        {
            try
            {
                string nome_local = string.Empty;
                var _local = await _dbContext.TblItensLocals.Where(x => x.IdLocal == id_local).ToListAsync();

                return _local;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //GET api/<lista-todos-os-locais>
        [HttpGet]
        [Route("lista-local")]
        public async Task<List<TblItensLocal>> ListaLocal()
        {
            try
            {
                var _local = await _dbContext.TblItensLocals.ToListAsync();

                return _local;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
