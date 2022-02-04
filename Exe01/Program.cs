using System;
using System.Collections;
using System.Collections.Generic;

namespace Exe01
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine($"Digite um número com 4 dígitos: ");
            int n = int.Parse(Console.ReadLine());
            int[] numero = new int[n];
            
            int quantidade = 0;
            for (int i = 0; i < numero[n]; i++)
            {
                if ((numero[n] >= 1000) && (numero[n] <= 9999) && (numero[n] % 2 == 0))
                {
                    quantidade = quantidade + numero[i];
                    System.Console.WriteLine(quantidade);
                }    
            }
            
            
        }
    }
}
