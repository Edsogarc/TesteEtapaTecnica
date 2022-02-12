using System;
using System.Collections;
using System.Collections.Generic;

namespace Exe01
{
    class Program
    {
        static public void Main(string[] args)
        {

            Console.WriteLine("Digite um número com 4 dígitos de 1000 a 9999");
            int numero = int.Parse(Console.ReadLine());
            
            VerificaPar(numero);
          
        }

        public static void VerificaPar(int numero)
        {
            int quantidade = 0;
            while (numero >= 1000 & numero <= 9999)
            {
                foreach (char caractere in numero.ToString())
                {
                    if (caractere % 2 == 0)
                    {
                        quantidade++;
                    }
                }
                Console.WriteLine($"A quantidade de números pares é {quantidade}");
                break;
            }

        }
    }
}
