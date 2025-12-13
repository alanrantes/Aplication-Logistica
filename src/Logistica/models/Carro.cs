namespace LogisticaApp.Models
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro() { }

        public Carro(
            string modelo,
            int ano,
            string cor,
            string marca,
            string placa,
            double valor,
            double capacidadeKg,
            int qtdRodas,
            int numeroPortas)
            : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirInfo() { }

        public override bool PodeTransportar(double peso)
        {
            return peso <= CapacidadeKg;
        }
    }
}
