namespace LogisticaApp.Models
{
    public class Carro : Veiculo, ITributo
    {
        public int NumeroPortas { get; set; }

        public Carro(
            string modelo, int ano, string cor, string marca, string placa,
            double valor, int qtdRodas, int numeroPortas
        ) : base(modelo, ano, cor, marca, placa, valor, qtdRodas)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo} - Ano {Ano}");
            Console.WriteLine($"Cor: {Cor} | Placa: {Placa}");
            Console.WriteLine($"Valor: R$ {Valor} | Portas: {NumeroPortas}");
        }

        public override bool PodeTransportar(double peso)
        {
            // carro padrão transporta pouco peso
            return peso <= 300;
        }

        public double CalcularValorIPVA()
        {
            // Exemplo simples: 4% do valor do veículo
            return Valor * 0.04;
        }
    }
}
