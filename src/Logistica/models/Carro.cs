namespace LogisticaApp.Models
{
    public class Carro : Veiculo, ITributo
    {
        public int NumeroPortas { get; set; }

        public Carro(
            string modelo,
            int ano,
            string cor,
            string marca,
            string placa,
            double valor,
            double capacidadeKg,
            int qtdRodas,
            int numeroPortas
        ) : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo} - Ano {Ano}");
            Console.WriteLine($"Cor: {Cor} | Placa: {Placa}");
            Console.WriteLine($"Valor: R$ {Valor} | Portas: {NumeroPortas}");
            Console.WriteLine($"Capacidade de carga: {CapacidadeKg} kg");
        }

        public override bool PodeTransportar(double peso)
        {
            return peso <= CapacidadeKg;
        }

        public double CalcularValorIPVA()
        {
            return Valor * 0.04;
        }
    }
}
