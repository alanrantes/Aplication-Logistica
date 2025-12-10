namespace LogisticaApp.Models
{
    public class Entrega
    {
        public int IdEntrega { get; set; }
        public Cliente Cliente { get; set; }
        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
        public Endereco Origem { get; set; }
        public Endereco Destino { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; private set; }
        public double DistanciaKm { get; set; }
        public NotaFiscal NotaFiscal { get; set; }

        public Entrega(
            int idEntrega,
            Cliente cliente,
            Motorista motorista,
            Veiculo veiculo,
            Endereco origem,
            Endereco destino,
            double distanciaKm,
            DateTime dataEntrega,
            NotaFiscal notaFiscal  // AGORA O CONSTRUTOR TEM A NF
        )
        {
            IdEntrega = idEntrega;
            Cliente = cliente;
            Motorista = motorista;
            Veiculo = veiculo;
            Origem = origem;
            Destino = destino;
            DistanciaKm = distanciaKm;
            DataEntrega = dataEntrega;
            NotaFiscal = notaFiscal;
            Status = "Pendente";
        }

        public void AtualizarStatus(string novoStatus)
        {
            Status = novoStatus;
        }

        public double CalcularTempoHoras()
        {
            double velocidadeMedia = 60;
            return DistanciaKm / velocidadeMedia;
        }

        public double CalcularCusto()
        {
            if (NotaFiscal != null)
                return NotaFiscal.ValorTotal;

            return DistanciaKm * 3.5;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("=== RESUMO DA ENTREGA ===");
            Console.WriteLine($"Entrega #{IdEntrega}");
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Motorista: {Motorista.Nome} ({Motorista.CategoriaCNH})");
            Console.WriteLine($"Veículo: {Veiculo.Marca} {Veiculo.Modelo}");
            Console.WriteLine($"Origem: {Origem}");
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Distância: {DistanciaKm} km");
            Console.WriteLine($"Custo: R$ {CalcularCusto():0.00}");
        }
    }
}
