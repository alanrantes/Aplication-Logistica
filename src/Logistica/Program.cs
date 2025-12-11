using LogisticaApp.Services;

var clienteService = new ClienteService();
var motoristaService = new MotoristaService();
var entregaService = new EntregaService();

bool executando = true;

while (executando)
{
    Console.WriteLine("\nMENU");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Cadastrar Motorista");
    Console.WriteLine("3 - Registrar Entrega");
    Console.WriteLine("4 - Listar Entregas");
    Console.WriteLine("0 - Sair");

    string opc = Console.ReadLine()!;

    switch (opc)
    {
        case "1":
            clienteService.CadastrarCliente();
            break;

        case "2":
            motoristaService.CadastrarMotorista();
            break;

        case "3":
            entregaService.RegistrarEntrega(
                clienteService.ListarClientes(),
                motoristaService.ListarMotoristas()
            );
            break;

        case "4":
            entregaService.ListarEntregas();
            break;

        case "0":
            executando = false;
            break;
    }
}
