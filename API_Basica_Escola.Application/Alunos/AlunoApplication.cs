using API_Basica_Escola.Models.Alunos;

namespace API_Basica_Escola.Application.Alunos
{
    public class AlunoApplication
    {
        //Metodo Cadastro aluno
        public List<Aluno> CadastroAluno(Aluno aluno)
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

            //Modelo de IF serve para procurar apenas o nome e trazer todas as informações.

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

        public Aluno EditaAluno(Aluno aluno)
        {
            var alunoMemoria = new Aluno();

            alunoMemoria.Nome = "Raphael";
            alunoMemoria.Idade = 24;
            alunoMemoria.Matricula = 777;
            alunoMemoria.Serie = "3A";

            alunoMemoria.Nome = aluno.Nome;
            alunoMemoria.Idade = aluno.Idade;
            alunoMemoria.Matricula = aluno.Matricula;
            alunoMemoria.Serie = aluno.Serie;

            return alunoMemoria;
        }

        public bool DeletaAluno(string nomeAluno)
        {
            var listaAlunos = new List<Aluno>();

            listaAlunos.Add(new Aluno() { Nome = "Raphael Giovanelli" });
            listaAlunos.Add(new Aluno() { Nome = "Alisson Costa" });

            foreach (var item in listaAlunos)
            {
                //ToUpper = Deixa todas as letras maiusculas. ToLower = Deixa todas as letras minusculas.
                //Contains = Busca se a informação que voce inseriu CONTEM dentro da string. Ex: Usuario digitou Giovanelli e a string é Raphael Giovanelli, o CONTAINS irá buscar a string
                //toda por conta de CONTER o Giovanelli.
                if (item.Nome.ToUpper() == nomeAluno.ToUpper() || item.Nome.ToUpper().Contains(nomeAluno.ToUpper()))
                {
                    listaAlunos.Remove(item);

                    return true;
                }
            }
            return false;
        }

        public Aluno BuscaAlunoPorNome(string nomeAluno)
        {
            var listaAlunos = new List<Aluno>();

            listaAlunos.Add(new Aluno() { Nome = "Raphael Giovanelli", Idade = 24 });
            listaAlunos.Add(new Aluno() { Nome = "Alisson Costa", Idade = 25 });
            listaAlunos.Add(new Aluno() { Nome = "Matheus Arduino", Idade = 24 });

            var aluno = listaAlunos.Where(x => x.Idade == 24);


            //PODER DO LAMBDA
            return listaAlunos.Find(x => x.Nome.ToUpper().Contains(nomeAluno.ToUpper()));

            //return listaAlunos.Find(x => x.Nome.ToUpper().Contains(nomeAluno.ToUpper())).Nome; -- RETORNA APENAS O NOME ENCONTRADO

            //foreach (var item in listaAlunos)
            //{
            //    //Busca apenas pelo nome e traz o cadastro completo.
            //    if (item.Nome.ToUpper() == nomeAluno.ToUpper() || item.Nome.ToUpper().Contains(nomeAluno.ToUpper()))
            //    {
            //        return item;
            //    }
            //}
            //return new Aluno();
        }
    }
}
