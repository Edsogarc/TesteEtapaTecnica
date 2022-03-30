using System;
using Exe03.Entities;
using Exe03.Entities.Enums;
using System.Globalization;

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Cinema: ");
            string nomeCinema = Console.ReadLine();
            Cinema cinema = new Cinema(nomeCinema);
            Filme filme = new Filme();
            string titulo;

            Console.Write("Digite a quantidade de filmes para adicionar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o titulo do Filme: ");
                titulo = Console.ReadLine();
                Console.Write("Qual o gênero: ");
                Genero genero = Enum.Parse<Genero>(Console.ReadLine());
                Console.Write("Duração do Filme em minutos: ");
                int duracaoEmMinutos = int.Parse(Console.ReadLine());
                Console.Write("Horário da sessão: ");
                string horarioSessao = Console.ReadLine();
                int id = i;
                filme = new Filme(titulo, genero, duracaoEmMinutos, horarioSessao, id);
                cinema.AdicionarFilme(filme);
            }
            Console.WriteLine();
            cinema.ListarFilmes();

            Console.Write("Digite o ID do filme a ser removido: ");
            int idf = int.Parse(Console.ReadLine());
            cinema.RemoverFilme(idf);

            cinema.ListarFilmes();
        }
    }
}
