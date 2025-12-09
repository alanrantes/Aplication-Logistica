using LogisticaApp.Models;

Console.WriteLine("========================================");
Console.WriteLine("     SISTEMA DE LOGÍSTICA - INICIAL     ");
Console.WriteLine("========================================");

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
            Console.WriteLine(">> Cadastrar Cliente (em construção)");
            break;

        case "2":
            Console.WriteLine(">> Cadastrar Motorista (em construção)");
            break;

        case "3":
            Console.WriteLine(">> Registrar Entrega (em construção)");
            break;

        case "4":
            Console.WriteLine(">> Listar Entregas (em construção)");
            break;

        case "0":
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

Console.WriteLine("Sistema finalizado!");
