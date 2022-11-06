using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paixao_Nordestina_API.Models;

namespace Paixao_Nordestina_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly SetDbContext _context;

        public CargoController(SetDbContext context)
        {
            _context = context;
        }

        // GET: api/Cargo - LISTA TODOS OS CARGOS
        [HttpGet]
        public IEnumerable<Cargo> GetCargos()
        {
            return _context.Cargos;
        }

        // GET: api/Cargo/id - LISTA CARGO POR ID
        [HttpGet("{id}")]
        public IActionResult GetCargoPorId(int id)
        {
            Cargo cargo = _context.Cargos.SingleOrDefault(modelo => modelo.id == id);
            if (cargo == null)
            {
                return NotFound();
            }
            return new ObjectResult(cargo);
        }

        // CRIA UM NOVO CARGO
        [HttpPost]
        public IActionResult CriarCurso(Cargo item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Cargos.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // ATUALIZA UM CARGO EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaCurso(int id, Cargo item)
        {
            if (id != item.id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        // APAGA UM CARGO POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaCurso(int id)
        {
            var curso = _context.Cargos.SingleOrDefault(m => m.id == id);

            if (curso == null)
            {
                return BadRequest();
            }

            _context.Cargos.Remove(curso);
            _context.SaveChanges();
            return Ok(curso);
        }
    }
}
