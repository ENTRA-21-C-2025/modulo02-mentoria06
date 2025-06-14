namespace modulo02_mentoria06.Heranca;

/// <summary>
/// Classe que representa uma moto, herdando características básicas de VeiculoPai
/// </summary>
public class Moto : VeiculoPai
{
    /// <summary>
    /// Cilindradas da moto em centímetros cúbicos (cc)
    /// </summary>
    public int Cilindradas { get; private set; }

    /// <summary>
    /// Construtor da classe Moto
    /// </summary>
    /// <param name="marca">Marca da moto</param>
    /// <param name="modelo">Modelo da moto</param>
    /// <param name="ano">Ano de fabricação</param>
    /// <param name="cilindradas">Cilindradas da moto em cc</param>
    public Moto(string marca, string modelo, int ano, int cilindradas) : base(marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }

    /// <summary>
    /// Simula a ação de empinar a moto
    /// </summary>
    /// <returns>Mensagem informando que a moto está empinando</returns>
    public string Empinar()
    {
        return $"{Marca} {Modelo} está empinando!";
    }

    /// <summary>
    /// Sobrescreve o método MostrarInfo para incluir as cilindradas
    /// </summary>
    /// <returns>String formatada com informações da moto incluindo cilindradas</returns>
    public override string MostrarInfo()
    {
        string infoBase = base.MostrarInfo();
        return $"{infoBase} - {Cilindradas}cc";
    }
} 