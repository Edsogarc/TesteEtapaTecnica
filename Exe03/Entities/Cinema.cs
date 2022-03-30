using Exe03.Entities.Enums;
using System.Text;
namespace Exe03.Entities
{
    class Cinema
    {
        public string Nome { get; set; }
        public Filme Endereco { get; set; }
        public List<Filme> FilmesEmCartaz { get; set; } = new List<Filme>();

        public Cinema()
        {

        }
        public Cinema(string nome)
        {
            Nome = nome;
        }
        public void AdicionarFilme(Filme filme)
        {
            FilmesEmCartaz.Add(filme);
        }
        public void RemoverFilme(int id)
        {
            FilmesEmCartaz.RemoveAt(id);
        }
        public void ListarFilmes()
        {
            Console.WriteLine("Cinema: "+Nome);
            foreach (Filme f in FilmesEmCartaz)
            {
                Console.WriteLine(f.Id);
                Console.WriteLine("Titulo: " + f.Titulo + ", Gênero: " + f.Genero + ", início da sessão: " + f.HorarioSessao+" horas");
                f.CalcularDuracaoEmHoras();
                f.RetornarHoraQueAcaba();
                Console.WriteLine();
            }
        }
    }
}