using Microsoft.AspNetCore.Mvc;
using TestePloomesAPI.Repos;
using TestePloomesAPI.Model;

namespace TestePloomesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private readonly PessoaRepositorio _pessoaRepositorio;

        public Controller() //usando o construtor do controller para instanciar o _PessoaRepositorio
        {
            _pessoaRepositorio = new PessoaRepositorio();
        }

        private readonly ILogger<Controller> _logger;
/*
        public Controller(ILogger<Controller> logger)
        {
            _logger = logger;
        }
*/
        [HttpGet(Name = "GetPessoas")]
        public ActionResult<IEnumerable<Pessoa>> Get()
        {
            return _pessoaRepositorio.GetPessoas;
        }

        [HttpPost]
        public void Post([FromBody] Pessoa pessoa)
        {
            _pessoaRepositorio.InsertPessoa(pessoa);
        }
    }
}