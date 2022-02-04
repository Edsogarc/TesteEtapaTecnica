using System;
using System.Collections.Generic;

namespace Exe03
{
    public class Cinema
    {
        public string Nome;
        public string Filme;
        public List<string> filmesEmCartaz;

        public Cinema(string nome, string filme)
        {
            Nome = nome;
            Filme = filme;
        }

        public void adicionarFilme()
        {
            Filme += Filme;
        }
        public void removerFilme()
        {
            Filme -= Filme;
        }
        public void listarFilmes()
        {
            System.Console.WriteLine();
        }
    }
}