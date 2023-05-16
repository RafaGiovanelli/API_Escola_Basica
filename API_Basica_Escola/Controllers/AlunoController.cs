using API_Basica_Escola.Application.Alunos;
using API_Basica_Escola.Models.Alunos;
using Microsoft.AspNetCore.Mvc;

namespace API_Basica_Escola.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpPost("InserirAlunos")]
        public string InserirAlunos(Aluno aluno)
        {
            new AlunoApplication().CadastroAluno(aluno);

            return "Cadastro concoluido com sucesso!!!";
        }

        [HttpGet("ListarAlunos")]
        public List<Aluno> ListaDeAlunos()
        {
            return new AlunoApplication().ListarAluno();
        }
        
        [HttpPut("EditaAluno")]
        public Aluno EditaAlunos(Aluno aluno)
        {
            return new AlunoApplication().EditaAluno(aluno);
        }
        
        [HttpDelete("DeletaAluno")]
        public bool DeletaAlunos(string nomeAluno)
        {
            var retornoBoolDeDelecaoAluno = new AlunoApplication().DeletaAluno(nomeAluno);
            return retornoBoolDeDelecaoAluno;
        }

        [HttpGet("BuscaAlunoPorNome")]
        public Aluno BuscaAlunoPorNome(string nomeAluno)
        {
            return new AlunoApplication().BuscaAlunoPorNome(nomeAluno);
        }

        [HttpPost("MediaAlunos")]
        public double MediaAlunos(List<double> notas)
        {
            return new AlunoApplication().MediaAluno(notas);
        }
    }
}