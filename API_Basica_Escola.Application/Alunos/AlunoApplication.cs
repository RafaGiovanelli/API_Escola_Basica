using API_Basica_Escola.Models.Alunos;

namespace API_Basica_Escola.Application.Alunos
{
    public class AlunoApplication
    {
        //Metodo Cadastro aluno
        public List<Aluno> CadastroAluno (Aluno aluno)
        {
            var listaAlunos = new List<Aluno>();

            listaAlunos.Add(aluno);

            return listaAlunos;
        }
        
        //Metodo Listar Aluno
        public List<Aluno> ListarAluno()
        {
            var aluno1 = new Aluno();
            var aluno2 = new Aluno();
            var listaAlunos = new List<Aluno>();

            aluno1.Nome = "Raphael";
            aluno1.Idade = 24;
            aluno1.Matricula = 777;
            aluno1.Serie = "3A";

            aluno2.Nome = "Alisson";
            aluno2.Idade = 25;
            aluno2.Matricula = 666;
            aluno2.Serie = "3F";

            listaAlunos.Add(aluno1);
            listaAlunos.Add(aluno2);

            return listaAlunos;
        }
        //Metodo Media Aluno
        public double MediaAluno(List<double> notas)
        {
            double media = 0;

            foreach (var item in notas)
            {
                media += item;
            }

            return media / notas.Count;
        }
    }
}
