using LogisticaApp.Models;

Console.WriteLine("========================================");
Console.WriteLine("     SISTEMA DE LOGÍSTICA - INICIAL     ");
Console.WriteLine("========================================");

List<Cliente> clientes = new List<Cliente>();
List<Motorista> motoristas = new List<Motorista>();
List<Entrega> entregas = new List<Entrega>();

bool executando = true;

while (executando)
{
    Console.WriteLine("\nMENU PRINCIPAL");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Cadastrar Motorista");
    Console.WriteLine("3 - Registrar Entrega");
    Console.WriteLine("4 - Listar Entregas");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string opc = Console.ReadLine()!;

    switch (opc)
    {
        case "1":
            Console.WriteLine("=== CADASTRAR CLIENTE ===");

            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine()!;

            Console.Write("CPF: ");
            string cpfCliente = Console.ReadLine()!;

            Console.Write("Telefone: ");
            string telCliente = Console.ReadLine()!;

            Console.Write("Email: ");
            string emailCliente = Console.ReadLine()!;

            Console.Write("ID do Cliente: ");
            int idCliente = int.Parse(Console.ReadLine()!);

            Console.Write("Tipo do cliente (Pessoa Física / Jurídica): ");
            string tipoCliente = Console.ReadLine()!;

            Cliente novoCliente = new Cliente(idCliente, tipoCliente, nomeCliente, cpfCliente, telCliente, emailCliente);
            clientes.Add(novoCliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
            break;


        case "2":
            Console.WriteLine("=== CADASTRAR MOTORISTA ===");

            Console.Write("Nome: ");
            string nomeMotorista = Console.ReadLine()!;

            Console.Write("CPF: ");
            string cpfMotorista = Console.ReadLine()!;

            Console.Write("Telefone: ");
            string telefoneMotorista = Console.ReadLine()!;

            Console.Write("Email: ");
            string emailMotorista = Console.ReadLine()!;

            Console.Write("ID do Motorista: ");
            int idMotorista = int.Parse(Console.ReadLine()!);

            Console.Write("Número da CNH: ");
            string numeroCnh = Console.ReadLine()!;

            Console.Write("Categoria CNH: ");
            string categoriaCnh = Console.ReadLine()!;

            Console.Write("Status: ");
            string statusMotorista = Console.ReadLine()!;

            Endereco enderecoM = new Endereco("Rua A", "100", "Centro", "Cidade", "Estado", "00000-000");

            Motorista novoMot = new Motorista(
                idMotorista, numeroCnh, categoriaCnh, statusMotorista,
                nomeMotorista, cpfMotorista, telefoneMotorista,
                emailMotorista, enderecoM
            );

            motoristas.Add(novoMot);

            Console.WriteLine("Motorista cadastrado com sucesso!");
            break;


        case "3":
            Console.WriteLine("=== REGISTRAR ENTREGA ===");

            if (clientes.Count == 0 || motoristas.Count == 0)
            {
                Console.WriteLine("⚠ É necessário cadastrar cliente e motorista antes de registrar entregas!");
                break;
            }

            Console.WriteLine("\nClientes:");
            foreach (var c in clientes)
                Console.WriteLine($"{c.IdCliente} - {c.Nome}");

            Console.Write("ID do cliente: ");
            Cliente cliEnt = clientes.First(c => c.IdCliente == int.Parse(Console.ReadLine()!));

            Console.WriteLine("\nMotoristas:");
            foreach (var m in motoristas)
                Console.WriteLine($"{m.IdMotorista} - {m.Nome}");

            Console.Write("ID do motorista: ");
            Motorista motEnt = motoristas.First(m => m.IdMotorista == int.Parse(Console.ReadLine()!));

            Carro carro = new Carro("Onix", 2020, "Prata", "Chevrolet", "ABC-1234", 45000, 300, 4, 4);

            Console.Write("Rua origem: ");
            string ruaO = Console.ReadLine()!;
            Endereco origem = new Endereco(ruaO, "100", "Centro", "Cidade", "Estado", "11111-111");

            Console.Write("Rua destino: ");
            string ruaD = Console.ReadLine()!;
            Endereco destino = new Endereco(ruaD, "200", "Centro", "Cidade", "Estado", "22222-222");

            Console.Write("Distância km: ");
            double dist = double.Parse(Console.ReadLine()!);

            Console.Write("ID da entrega: ");
            int idEnt = int.Parse(Console.ReadLine()!);

            NotaFiscal nf = new NotaFiscal(idEnt, DateTime.Now, cliEnt, carro, 100);

            Entrega entrega = new Entrega(
                idEnt, cliEnt, motEnt, carro,
                origem, destino,
                dist, DateTime.Now,
                nf
            );

            entregas.Add(entrega);

            Console.WriteLine("Entrega registrada com sucesso!");
            break;


        case "4":
            Console.WriteLine("\n=== LISTA DE ENTREGAS ===");

            if (entregas.Count == 0)
            {
                Console.WriteLine("Nenhuma entrega registrada.");
                break;
            }

            foreach (var e in entregas)
            {
                e.ExibirResumo();
                Console.WriteLine("-----------------------------------");
            }

            break;


        case "0":
            Console.WriteLine("Encerrando sistema...");
            executando = false;
            break;


        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}

Console.WriteLine("Sistema finalizado!");
