using LogisticaApp.Models;

namespace LogisticaApp.Services
{
    public class MotoristaService
    {
        private List<Motorista> motoristas = new();

        public void CadastrarMotorista()
        {
            Console.WriteLine("=== CADASTRAR MOTORISTA ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("CPF: ");
            string cpf = Console.ReadLine()!;

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine()!;

            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            Console.Write("ID do Motorista: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Número da CNH: ");
            string cnh = Console.ReadLine()!;

            Console.Write("Categoria CNH: ");
            string categoria = Console.ReadLine()!;

            Console.Write("Status: ");
            string status = Console.ReadLine()!;

            Endereco endereco = new Endereco("Rua A", "100", "Centro", "Cidade", "Estado", "00000-000");

            motoristas.Add(
                new Motorista(id, cnh, categoria, status, nome, cpf, telefone, email, endereco)
            );

            Console.WriteLine("✅ Motorista cadastrado com sucesso!");
        }

        public List<Motorista> ListarMotoristas()
        {
            return motoristas;
        }
    }
}
