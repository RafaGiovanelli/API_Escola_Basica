using API_Basica_Escola.Models.Alunos;
using API_Basica_Escola.Models.Escola;
using System.Security.Cryptography.X509Certificates;

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

        //Edita Escola
        public Escolas EditaEscola(Escolas editaEscolas)
        {
            var escolaMemoria = new Escolas()
            {
                Nome = "Pantoja",
                Logradouro = "Rua Cananeia",
                Numero = 115,
                Bairro = "Vila Prudente",
                Capacidade = 1000
            };

            escolaMemoria.Nome = editaEscolas.Nome;
            escolaMemoria.Logradouro = editaEscolas.Logradouro;
            escolaMemoria.Numero = editaEscolas.Numero;
            escolaMemoria.Bairro = editaEscolas.Bairro;
            escolaMemoria.Capacidade = editaEscolas.Capacidade;

            return escolaMemoria;
        }
    
        //Deleta Escola
        public bool DeletaEscolas(string nomeEscolas)
        {
            var listaEscolas = new List<Escolas>();

            listaEscolas.Add(new Escolas(){Nome = "Pantoja", Logradouro = "Rua que sobe", Numero = 115, Bairro = "Vila Prudente", Capacidade = 10000});
            listaEscolas.Add(new Escolas(){Nome = "Civitatis", Logradouro = "Rua que desce", Numero = 935, Bairro = "Vila Prudente", Capacidade = 1000});

            if (listaEscolas.Remove(listaEscolas.Find(x => x.Nome.ToUpper() == nomeEscolas.ToUpper())))
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        //Busca Escola Pelo Nome
        public Escolas BuscaEscolas(string nomeEscolas)
        {
            var listaEscolas = new List<Escolas>();

            listaEscolas.Add(new Escolas() { Nome = "Pantoja", Logradouro = "Rua que sobe", Numero = 115, Bairro = "Vila Prudente", Capacidade = 10000 });
            listaEscolas.Add(new Escolas() { Nome = "Civitatis", Logradouro = "Rua que desce", Numero = 935, Bairro = "Vila Prudente", Capacidade = 1000 });

            return listaEscolas.Find(x => x.Nome.ToUpper() == nomeEscolas.ToUpper());
        }
    }
}
