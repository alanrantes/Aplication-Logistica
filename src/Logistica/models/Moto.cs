namespace LogisticaApp.Models
{
    public class Moto : Veiculo, ITributo
    {
        public int Cilindrada { get; set; }

        public Moto(
            string modelo, int ano, string cor, string marca, string placa,
            double valor, double capacidadeKg, int qtdRodas,
            int cilindrada
        ) : base(modelo, ano, cor, marca, placa, valor, capacidadeKg, qtdRodas)
        {
            Cilindrada = cilindrada;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo} - {Cilindrada}cc - Ano {Ano}");
            Console.WriteLine($"Cor: {Cor} | Placa: {Placa}");
            Console.WriteLine($"Valor: R$ {Valor}");
        }

        public override bool PodeTransportar(double peso)
        {
            return peso <= 50;
        }

        public double CalcularValorIPVA()
        {
            return Valor * 0.02;
        }
    }
}
