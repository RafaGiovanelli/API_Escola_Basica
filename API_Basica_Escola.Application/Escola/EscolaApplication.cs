using API_Basica_Escola.Models.Alunos;
using API_Basica_Escola.Models.Escola;

namespace API_Basica_Escola.Application.Escola
{
    public class EscolaApplication
    {
        //Cadastra Escola
        public List<Escolas> CadastroEscola(Escolas escolas)
        {
            var listaEscolas = new List<Escolas>();

            listaEscolas.Add(escolas);

            return listaEscolas;
        }

        //Lista Escola
        public List<Escolas> ListaEscola()
        {
            var escola1 = new Escolas();
            var escola2 = new Escolas();
            var listaEscolas = new List<Escolas>();

            escola1.Nome = "Pantoja";
            escola1.Logradouro = "Rua que sobe";
            escola1.Numero = 115;
            escola1.Bairro = "Vila Prudente";
            escola1.Capacidade = 10000;

            escola2.Nome = "Civitatis";
            escola2.Logradouro = "Rua que desce";
            escola2.Numero = 935;
            escola2.Bairro = "Vila Prudente";
            escola2.Capacidade = 1000;

            listaEscolas.Add(escola1);
            listaEscolas.Add(escola2);

            return listaEscolas;

        }
    }
}
