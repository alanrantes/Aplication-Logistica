using LogisticaApp.Models;

namespace LogisticaApp.Services
{
    public class EntregaService
    {
        private List<Entrega> entregas = new();

        public void RegistrarEntrega(
            List<Cliente> clientes,
            List<Motorista> motoristas
        )
        {
            if (clientes.Count == 0 || motoristas.Count == 0)
            {
                Console.WriteLine("⚠ Cadastre cliente e motorista primeiro!");
                return;
            }

            Console.WriteLine("\nClientes:");
            foreach (var c in clientes)
                Console.WriteLine($"{c.IdCliente} - {c.Nome}");

            Console.Write("ID do cliente: ");
            Cliente cliente = clientes.First(c => c.IdCliente == int.Parse(Console.ReadLine()!));

            Console.WriteLine("\nMotoristas:");
            foreach (var m in motoristas)
                Console.WriteLine($"{m.IdMotorista} - {m.Nome}");

            Console.Write("ID do motorista: ");
            Motorista motorista = motoristas.First(m => m.IdMotorista == int.Parse(Console.ReadLine()!));

            Carro carro = new Carro("Onix", 2020, "Prata", "Chevrolet", "ABC-1234", 45000, 300, 4, 4);

            Console.Write("Rua origem: ");
            Endereco origem = new Endereco(Console.ReadLine()!, "100", "Centro", "Cidade", "Estado", "11111-111");

            Console.Write("Rua destino: ");
            Endereco destino = new Endereco(Console.ReadLine()!, "200", "Centro", "Cidade", "Estado", "22222-222");

            Console.Write("Distância km: ");
            double dist = double.Parse(Console.ReadLine()!);

            Console.Write("ID da entrega: ");
            int id = int.Parse(Console.ReadLine()!);

            NotaFiscal nf = new NotaFiscal(id, DateTime.Now, cliente, carro, 100);

            entregas.Add(new Entrega(
                id, cliente, motorista, carro,
                origem, destino, dist, DateTime.Now, nf
            ));

            Console.WriteLine("✅ Entrega registrada!");
        }

        public void ListarEntregas()
        {
            if (entregas.Count == 0)
            {
                Console.WriteLine("Nenhuma entrega registrada.");
                return;
            }

            foreach (var e in entregas)
            {
                e.ExibirResumo();
                Console.WriteLine("-------------------------");
            }
        }
    }
}
