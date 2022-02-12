namespace Exe02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiplicando: ");
            int multiplicando = int.Parse(Console.ReadLine());
            Console.WriteLine("Início do intervalo: ");
            int intervalo = int.Parse(Console.ReadLine());
            Console.WriteLine("Fim do intervalo: ");
            int fimIntervalo = int.Parse(Console.ReadLine());
            int resultado = 0;

            Console.WriteLine($"Multiplicando:{multiplicando}");
            Console.WriteLine($"Início do intervalo:{intervalo}");
            Console.WriteLine($"Fim do intervalo:{fimIntervalo}");

            if((multiplicando <= 5000) && (multiplicando > 0) && (intervalo <= 5000) && (intervalo > 0) && (fimIntervalo <= 5000) && (fimIntervalo > 0))
            {
                if (intervalo < fimIntervalo && fimIntervalo - intervalo < 10)
                {
                    for (int i = 1; intervalo <= fimIntervalo; i++)
                    {
                        resultado = multiplicando * intervalo;
                        Console.WriteLine($"{multiplicando} X {intervalo} = {resultado}");
                        intervalo++;
                    }
                }
                else
                {
                    Console.WriteLine($"O início do intervalo deve ser menor que seu fim");
                }
            }
        }

    }
}