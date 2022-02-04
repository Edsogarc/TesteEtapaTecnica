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

            if((multiplicando > 5000) && (multiplicando < 0) && (intervalo > 5000) && (intervalo < 0) && (fimIntervalo > 5000) && (fimIntervalo < 0))
            {
                Console.WriteLine("Digite um número menor que 5000 e positivo: ");
                multiplicando = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um intervalo menor que 5000 e positivo: ");
                intervalo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um fim de intervalo menor que 5000 e positivo: ");
                fimIntervalo = int.Parse(Console.ReadLine());
            }
            else
            {
                
            }
        }

    }
}