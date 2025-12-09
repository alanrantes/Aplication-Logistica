namespace LogisticaApp.Models
{
    public class Cliente : Pessoa
    {
        public int IdCliente { get; set; }
        public string TipoCliente { get; set; }

        public Cliente(int idCliente, string tipoCliente, string nome, string cpf, string telefone, string email)
    : base(nome, cpf, telefone, email, new Endereco("", "", "", "", "", ""))
        {
            IdCliente = idCliente;
            TipoCliente = tipoCliente;
        }


        public override void ExibirInfo()
        {
            Console.WriteLine($"Cliente #{IdCliente} - {Nome}");
            Console.WriteLine($"Tipo: {TipoCliente}");
            Console.WriteLine($"CPF: {Cpf} | Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Endereço: {Endereco}");
        }

        public void AtualizarCadastro(string telefoneNovo, string emailNovo)
        {
            Telefone = telefoneNovo;
            Email = emailNovo;
        }
    }
}
