namespace LogisticaApp.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, string cpf, string telefone, string email, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }

        public abstract void ExibirInfo();

        public bool ValidarCPF()
        {
            return Cpf != null && Cpf.Length == 11;
        }
    }
}
