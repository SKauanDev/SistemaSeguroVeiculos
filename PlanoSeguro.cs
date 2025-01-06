public class PlanoSeguro
{
    public string TipoPlano { get; private set; }
    public decimal ValorMensal { get; private set; }

    public PlanoSeguro(string tipoPlano)
    {
        if (tipoPlano == "Básico")
        {
            TipoPlano = tipoPlano;
            ValorMensal = 100; // Exemplo de valor
        }
        else if (tipoPlano == "Intermediário")
        {
            TipoPlano = tipoPlano;
            ValorMensal = 200; // Exemplo de valor
        }
        else if (tipoPlano == "Completo")
        {
            TipoPlano = tipoPlano;
            ValorMensal = 300; // Exemplo de valor
        }
        else
        {
            throw new ArgumentException("Tipo de plano inválido!");
        }
    }
}
