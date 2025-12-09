namespace LogisticaApp.Models
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public double ValorServico { get; set; }
        public double Imposto { get; set; }
        public double ValorTotal => ValorServico + Imposto;

        public NotaFiscal(int numeroNF, DateTime dataEmissao, Cliente cliente, Veiculo veiculo, double valorServico)
        {
            NumeroNF = numeroNF;
            DataEmissao = dataEmissao;
            Cliente = cliente;
            Veiculo = veiculo;
            ValorServico = valorServico;
            Imposto = valorServico * 0.12;
        }

        public void ExibirNF()
        {
            Console.WriteLine("=== NOTA FISCAL ===");
            Console.WriteLine($"NF: {NumeroNF} | Emitida em: {DataEmissao}");
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Veículo: {Veiculo.Marca} {Veiculo.Modelo} - Placa {Veiculo.Placa}");
            Console.WriteLine($"Valor do serviço: R$ {ValorServico}");
            Console.WriteLine($"Impostos: R$ {Imposto}");
            Console.WriteLine($"Total: R$ {ValorTotal}");
        }
    }
}
