using API_Basica_Escola.Application.Professor;
using API_Basica_Escola.Models.Escola;
using API_Basica_Escola.Models.Professor;
using Microsoft.AspNetCore.Mvc;

namespace API_Basica_Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        [HttpPost("InserirProfessor")]
        public string InserirProfessor(Professores nomeProfessor)
        {
            new ProfessorApplication().CadastraProfessor(nomeProfessor);

            return "Cadastro efetuado com sucesso!!!";
        }

        [HttpGet("ListaProfessores")]
        public List<Professores> ListaDeProfessores()
        {
            return new ProfessorApplication().ListaProfessores();
        }

        [HttpPut("EditaProfessor")]
        public Professores EditaProfessor(Professores nomeProfessor)
        {
            return new ProfessorApplication().EditarProfessor(nomeProfessor);
        }

        [HttpDelete("DeletaProfessor")]
        public bool DeletaProfessor(string nomeProfessor)
        {
            return new ProfessorApplication().DeletarProfessores(nomeProfessor);
        }

        [HttpGet("BuscaProfessorPorNome")]
        public Professores BuscaProfessorPorNome(string nomeProfessor)
        {
            return new ProfessorApplication().BuscaProfessores(nomeProfessor);
        }
    }
}
