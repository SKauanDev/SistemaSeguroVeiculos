namespace SistemaSeguroVeiculos
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string Placa { get; set; }

        public Carro(string modelo, int ano, decimal valor, string placa)
        {
            Modelo = modelo;
            Ano = ano;
            Valor = valor;
            Placa = placa;
        }
    }
}
