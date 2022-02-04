namespace Exe04
{
    public class Veiculo
    {
        public string Nome;
        public string Marca;
        public int CapacidadeDoTanque;
        public int LitrosNoTanque;

        public int Abastecer(int capacidadeDoTanque, int litrosNoTanque)
        {
            CapacidadeDoTanque = capacidadeDoTanque;
            LitrosNoTanque = litrosNoTanque;
            if (CapacidadeDoTanque < LitrosNoTanque)
            {
                return LitrosNoTanque;
            }
            else
            {
                return CapacidadeDoTanque;
            }
        }
    }
}