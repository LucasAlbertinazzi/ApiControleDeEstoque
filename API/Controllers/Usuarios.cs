using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Utils;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuarios : ControllerBase
    {
        private readonly dbBanco _dbContext = new();

        //POST api/>
        [HttpPost]
        public async Task<IActionResult> Verifica(Login login)
        {
            string senhacripto = Cripto.Criptografar(login.senha);

            var usuario = await _dbContext.TblUsuarios.Where(x =>
                x.Username == login.usuario && x.Password == senhacripto).FirstOrDefaultAsync();

            if (usuario != null && usuario.IdUsuario > 0)
            {
                return Ok(usuario);
            }

            else
            {
                return Unauthorized();
            }
        }
    }
}