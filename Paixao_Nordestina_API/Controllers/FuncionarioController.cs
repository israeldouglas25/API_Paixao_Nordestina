using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paixao_Nordestina_API.Models;

namespace Paixao_Nordestina_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly SetDbContext _context;

        public FuncionarioController(SetDbContext context)
        {
            _context = context;
        }

        // GET: api/Funcionario - LISTA TODOS OS FUNCIONARIOS
        [HttpGet]
        public IEnumerable<Funcionario> GetFuncionarios()
        {
            return _context.Funcionarios;
        }

        // GET: api/Funcionario/id - LISTA FUNCIONARIO POR ID
        [HttpGet("{id}")]
        public IActionResult GetFuncionarioPorId(int id)
        {
            Funcionario funcionario = _context.Funcionarios.SingleOrDefault(modelo => modelo.id == id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return new ObjectResult(funcionario);
        }

        // APAGA UM FUNCIONARIO POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaFuncionario(int id)
        {
            var funcionario = _context.Funcionarios.SingleOrDefault(m => m.id == id);

            if (funcionario == null)
            {
                return BadRequest();
            }

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
            return Ok(funcionario);
        }
    }
}
