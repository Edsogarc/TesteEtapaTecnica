using System.Globalization;

namespace Exe04
{
    class Veiculo
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int CapacidadeDoTanque { get; set; }
        public int LitrosNoTanque { get; set; }

        public Veiculo(string nome, string marca, int capacidadeDoTanque, int litrosNoTanque)
        {
            Nome = nome;
            Marca = marca;
            CapacidadeDoTanque = capacidadeDoTanque;
            LitrosNoTanque = litrosNoTanque;
        }
        public Veiculo()
        {

        }
        public void Abastecer(int litrosNoTanque)
        {
            int excesso = 0;
            double valor = 0;
            int capacidade = 0;
            if (litrosNoTanque > CapacidadeDoTanque)
            {
                excesso = litrosNoTanque - CapacidadeDoTanque;
                capacidade = litrosNoTanque - excesso;
                Console.WriteLine("Quantidade excedente: "+excesso+" litro(s)");
                Console.WriteLine("Quantidade abastecida: "+capacidade+" litros");
                valor = capacidade * 7.0;
                Console.WriteLine("Valor a ser pago: R$"+valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Quantidade abastecida: "+litrosNoTanque+" litros");
                valor = capacidade * 7.0;
                Console.WriteLine("Valor a ser pago: R$"+valor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}