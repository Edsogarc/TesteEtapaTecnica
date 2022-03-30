class Program
{
    static void Main(string[] args)
    {
        Console.Write("Multiplicando: ");
        int multiplicando = int.Parse(Console.ReadLine());
        Console.Write("Início do intervalo: ");
        int intervalo = int.Parse(Console.ReadLine());
        Console.Write("Fim do intervalo: ");
        int fimIntervalo = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int resultado = 0;

        Console.WriteLine($"Multiplicando:{multiplicando}");
        Console.WriteLine($"Início do intervalo:{intervalo}");
        Console.WriteLine($"Fim do intervalo:{fimIntervalo}");

        if ((multiplicando >= 0 && multiplicando <= 5000) && (intervalo >= 0 && intervalo <= 5000) && (fimIntervalo >= 0 && fimIntervalo <= 5000))
        {
            while (!(intervalo < fimIntervalo) || !(fimIntervalo - intervalo < 10))
            {
                Console.WriteLine($"O início do intervalo deve ser menor que seu fim");
                Console.WriteLine("Digite novamente os intervalos");
                
                Console.Write("Início do intervalo: ");
                intervalo = int.Parse(Console.ReadLine());
                Console.Write("Fim do intervalo: ");
                fimIntervalo = int.Parse(Console.ReadLine());
            }
            for (int i = 1; intervalo <= fimIntervalo; i++)
            {
                resultado = multiplicando * intervalo;
                Console.WriteLine($"{multiplicando} X {intervalo} = {resultado}");
                intervalo++;
            }
        }
    }
}