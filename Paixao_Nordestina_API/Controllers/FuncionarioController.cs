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

        [HttpGet]
        public IEnumerable<Funcionario> GetFuncionarios()
        {
            return _context.Funcionarios;
        }
    }
}
