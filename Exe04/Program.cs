namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Informe o modelo do carro: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("Informe a quantidade em litros para abastecer: ");
            int litrosNoTanque = int.Parse(Console.ReadLine());
            int capacidadeDoTanque = 60;
            Veiculo veiculo = new Veiculo(nome, marca, capacidadeDoTanque, litrosNoTanque);
            Console.WriteLine();
            veiculo.Abastecer(litrosNoTanque);
        }
    }
}