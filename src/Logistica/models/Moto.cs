namespace LogisticaApp.Models
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        // 🔹 Construtor vazio (obrigatório para o EF)
        public Moto() { }

        public Moto(
            string modelo,
            int ano,
            string cor,
            string marca,
            string placa,
            double valor,
            double capacidadeKg,
            int qtdRodas,
            int cilindradas)
            : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInfo()
        {
            // Pode deixar vazio por enquanto
        }

        public override bool PodeTransportar(double peso)
        {
            return peso <= CapacidadeKg;
        }
    }
}
