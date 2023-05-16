using API_Basica_Escola.Models.Professor;

namespace API_Basica_Escola.Application.Professor
{
    public class ProfessorApplication
    {
        public List<Professores> CadastraProfessor(Professores nomeProfessor)
        {
            var listaProfessor = new List<Professores>();

            listaProfessor.Add(nomeProfessor);

            return listaProfessor;
        }

        public List<Professores> ListaProfessores()
        {
            var listaProfessor = new List<Professores>();
            var memoriaProfessor1 = new Professores();
            var memoriaProfessor2 = new Professores();

            memoriaProfessor1.Nome = "Alberto";
            memoriaProfessor1.Idade = 46;
            memoriaProfessor1.Matricula = 6957;
            memoriaProfessor1.Materia = "Matematica";

            memoriaProfessor2.Nome = "Wadecir";
            memoriaProfessor2.Idade = 57;
            memoriaProfessor2.Matricula = 7531;
            memoriaProfessor2.Materia = "Portugues";

            listaProfessor.Add(memoriaProfessor1);
            listaProfessor.Add(memoriaProfessor2);

            return listaProfessor;
        }

        public Professores EditarProfessor(Professores editaProfessor)
        {
            var memoriaProfessor = new Professores()
            {
                Nome = "Alberto",
                Idade = 46,
                Matricula = 6957,
                Materia = "Matematica"
            };

            memoriaProfessor.Nome = editaProfessor.Nome;
            memoriaProfessor.Idade = editaProfessor.Idade;
            memoriaProfessor.Matricula = editaProfessor.Matricula;
            memoriaProfessor.Materia = editaProfessor.Materia;

            return memoriaProfessor;
        }

        public bool DeletarProfessores(string nomeProfessor)
        {

            var listaProfessores = new List<Professores>();

            listaProfessores.Add(new Professores() { Nome = "Alberto", Idade = 46, Matricula = 6957, Materia = "Matematica" });
            listaProfessores.Add(new Professores() { Nome = "Waldecir", Idade = 57, Matricula = 7531, Materia = "Portugues" });

            if (listaProfessores.Remove(listaProfessores.Find(x => x.Nome.ToUpper() == nomeProfessor.ToUpper())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Professores BuscaProfessores(string nomeProfessor)
        {
            var listaProfessor = new List<Professores>();

            listaProfessor.Add(new Professores() { Nome = "Alberto", Idade = 46, Matricula = 6957, Materia = "Matematica" });
            listaProfessor.Add(new Professores() { Nome = "Waldecir", Idade = 57, Matricula = 7531, Materia = "Portugues" });

            return listaProfessor.Find(x => x.Nome.ToUpper() == nomeProfessor.ToUpper());
        }
    }
}
