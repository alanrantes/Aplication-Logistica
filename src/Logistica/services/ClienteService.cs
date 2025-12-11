using LogisticaApp.Models;

namespace LogisticaApp.Services
{
    public class ClienteService
    {
        private List<Cliente> clientes = new();

        public void CadastrarCliente()
        {
            Console.WriteLine("=== CADASTRAR CLIENTE ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("CPF: ");
            string cpf = Console.ReadLine()!;

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine()!;

            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            Console.Write("ID do Cliente: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Tipo do cliente: ");
            string tipo = Console.ReadLine()!;

            clientes.Add(new Cliente(id, tipo, nome, cpf, telefone, email));

            Console.WriteLine("✅ Cliente cadastrado com sucesso!");
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }
    }
}
