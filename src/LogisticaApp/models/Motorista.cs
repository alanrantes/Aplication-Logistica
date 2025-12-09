namespace LogisticaApp.Models
{
    public class Motorista : Pessoa
    {
        public int IdMotorista { get; set; }
        public string NumeroCNH { get; set; }
        public string CategoriaCNH { get; set; } 
        public string Status { get; set; } 

        // Construtor completo
        public Motorista(
            int idMotorista,
            string numeroCNH,
            string categoriaCNH,
            string status,
            string nome,
            string cpf,
            string telefone,
            string email,
            Endereco endereco
        ) : base(nome, cpf, telefone, email, endereco)
        {
            IdMotorista = idMotorista;
            NumeroCNH = numeroCNH;
            CategoriaCNH = categoriaCNH;
            Status = status;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Motorista #{IdMotorista} - {Nome}");
            Console.WriteLine($"CNH: {NumeroCNH} | Categoria: {CategoriaCNH}");
            Console.WriteLine($"Status atual: {Status}");
            Console.WriteLine($"CPF: {Cpf} | Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Endereço: {Endereco}");
        }

        public void AtualizarStatus(string novoStatus)
        {
            Status = novoStatus;
        }
    }
}
