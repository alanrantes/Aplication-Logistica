namespace LogisticaApp.Models
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public int QtdRodas { get; set; }

        public Veiculo(string modelo, int ano, string cor, string marca, string placa, double valor, int qtdRodas)
        {
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Marca = marca;
            Placa = placa;
            Valor = valor;
            QtdRodas = qtdRodas;
        }

        public abstract void ExibirInfo();
        public abstract bool PodeTransportar(double peso);
    }
}
