using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paixao_Nordestina_API.Models;

namespace Paixao_Nordestina_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly SetDbContext _context;

        public EnderecoController(SetDbContext context)
        {
            _context = context;
        }

        // GET: api/Endereco - LISTA TODOS OS ENDERECOS
        [HttpGet]
        public IEnumerable<Endereco> GetFuncionarios()
        {
            return _context.Enderecos;
        }

        // GET: api/Endereco/id - LISTA ENDERECO POR ID
        [HttpGet("{id}")]
        public IActionResult GetFuncionarioPorId(int id)
        {
            Endereco endereco = _context.Enderecos.SingleOrDefault(modelo => modelo.id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            return new ObjectResult(endereco);
        }

        // APAGA UM ENDERECO POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            var endereco = _context.Enderecos.SingleOrDefault(m => m.id == id);

            if (endereco == null)
            {
                return BadRequest();
            }

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return Ok(endereco);
        }
    }
}
