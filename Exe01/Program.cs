using System;

//Quantidade de pares número inteiro
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Descubra quantos dígitos pares tem no número: ");
        int valor = int.Parse(Console.ReadLine());
        while (valor < 1000 || valor > 9999)
        {
            Console.Write("Digite um número entre 1000 e 9999 ou com 4 dígitos: ");
            valor = int.Parse(Console.ReadLine());
        }
        int cont = 0;
        foreach (char d in valor.ToString())
        {
            if (d % 2 == 0)
            {
                cont++;
            }
        }
        Console.WriteLine("Quantidade de dígitos pares é: "+cont);
    }
}