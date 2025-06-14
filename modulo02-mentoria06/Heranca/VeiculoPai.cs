namespace modulo02_mentoria06.Heranca;

/// <summary>
/// Classe base que representa um veículo genérico com propriedades e comportamentos comuns.
/// </summary>
public class VeiculoPai
{
    /// <summary>
    /// Marca do veículo
    /// </summary>
    public string Marca { get; private set; }

    /// <summary>
    /// Modelo do veículo
    /// </summary>
    public string Modelo { get; private set; }

    /// <summary>
    /// Ano de fabricação do veículo
    /// </summary>
    public int Ano { get; private set; }

    /// <summary>
    /// Velocidade atual do veículo em km/h
    /// </summary>
    public int Velocidade { get; private set; }

    /// <summary>
    /// Construtor da classe VeiculoPai
    /// </summary>
    /// <param name="marca">Marca do veículo</param>
    /// <param name="modelo">Modelo do veículo</param>
    /// <param name="ano">Ano de fabricação</param>
    public VeiculoPai(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Velocidade = 0;
    }

    /// <summary>
    /// Aumenta a velocidade do veículo em 10 km/h
    /// </summary>
    /// <returns>Mensagem informando a nova velocidade</returns>
    public virtual string Acelerar()
    {
        Velocidade += 10;
        return $"{Marca} {Modelo} acelerou para {Velocidade} km/h";
    }

    /// <summary>
    /// Diminui a velocidade do veículo em 10 km/h, se a velocidade atual for maior que zero
    /// </summary>
    /// <returns>Mensagem informando a nova velocidade</returns>
    public virtual string Frear()
    {
        if (Velocidade > 0)
        {
            Velocidade -= 10;
        }
        return $"{Marca} {Modelo} freou para {Velocidade} km/h";
    }

    /// <summary>
    /// Retorna as informações básicas do veículo
    /// </summary>
    /// <returns>String formatada com marca, modelo e ano do veículo</returns>
    public virtual string MostrarInfo()
    {
        return $"{Marca} {Modelo} ({Ano})";
    }
}
