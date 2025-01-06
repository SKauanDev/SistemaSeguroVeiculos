using SistemaSeguroVeiculos;

public class Cliente
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public Carro Carro { get; private set; }
    public PlanoSeguro PlanoSeguro { get; private set; }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }

    public void AtribuirCarro(Carro carro)
    {
        Carro = carro;
    }

    public void AtribuirPlano(PlanoSeguro plano)
    {
        PlanoSeguro = plano;
    }
}
