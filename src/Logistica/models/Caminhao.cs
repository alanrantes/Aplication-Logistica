namespace LogisticaApp.Models
{
    public class Caminhao : Veiculo
    {
        public int NumeroEixos { get; set; }

        // 🔹 Construtor vazio (obrigatório para o EF)
        public Caminhao() { }

        public Caminhao(
            string modelo,
            int ano,
            string cor,
            string marca,
            string placa,
            double valor,
            double capacidadeKg,
            int qtdRodas,
            int numeroEixos)
            : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            NumeroEixos = numeroEixos;
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
