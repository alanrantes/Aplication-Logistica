namespace LogisticaApp.Models
{
    public class Caminhao : Veiculo, ITributo
    {
        public double CapacidadeCargaKg { get; set; }
        public int NumeroEixos { get; set; }

        public Caminhao(
            string modelo, int ano, string cor, string marca, string placa,
            double valor, double capacidadeKg, int qtdRodas,
            double capacidadeCargaKg, int numeroEixos
        ) : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            CapacidadeCargaKg = capacidadeCargaKg;
            NumeroEixos = numeroEixos;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Caminhão: {Marca} {Modelo} - Ano {Ano}");
            Console.WriteLine($"Cor: {Cor} | Placa: {Placa}");
            Console.WriteLine($"Valor: R$ {Valor}");
            Console.WriteLine($"Eixos: {NumeroEixos} | Capacidade: {CapacidadeCargaKg} kg");
        }

        public override bool PodeTransportar(double peso)
        {
            return peso <= CapacidadeCargaKg;
        }

        public double CalcularValorIPVA()
        {
            return Valor * 0.015;
        }
    }
}
