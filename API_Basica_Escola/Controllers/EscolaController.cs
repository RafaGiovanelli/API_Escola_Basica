using API_Basica_Escola.Application.Escola;
using API_Basica_Escola.Models.Escola;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Basica_Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        [HttpPost("InserirEscola")]
        public string CadastroEscola(Escolas escolas)
        {
            new EscolaApplication().CadastroEscola(escolas);

            return "Cadastro efetuado com sucesso!!!";
        }
        [HttpGet("ListarEscolas")]
        public List<Escolas> ListarEscolas() 
        {
            return new EscolaApplication().ListaEscola();
        }
    }
}
