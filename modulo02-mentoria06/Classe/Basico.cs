namespace modulo02_mentoria06.Classe;

/// <summary>
/// Representa um bolo com suas características e comportamentos.
/// Esta classe permite criar e manipular bolos com diferentes sabores e tamanhos.
/// </summary>
public class Bolo
{
    /// <summary>
    /// Obtém o sabor do bolo (ex: chocolate, morango).
    /// </summary>
    public string Sabor { get; private set; }      // Exemplo: "chocolate", "morango"

    /// <summary>
    /// Obtém o tamanho do bolo (ex: pequeno, médio, grande).
    /// </summary>
    public string Tamanho { get; private set; }    // Exemplo: "pequeno", "médio", "grande"

    /// <summary>
    /// Obtém o estado atual da temperatura do bolo (frio/quente).
    /// </summary>
    public string Temperatura { get; private set; } // Estado atual do bolo (frio/quente)

    /// <summary>
    /// Inicializa uma nova instância da classe Bolo.
    /// </summary>
    /// <param name="sabor">O sabor do bolo (ex: chocolate, morango).</param>
    /// <param name="tamanho">O tamanho do bolo (ex: pequeno, médio, grande).</param>
    public Bolo(string sabor, string tamanho)
    {
        Sabor = sabor;
        Tamanho = tamanho;
        Temperatura = "frio";  // Começa frio
    }

    /// <summary>
    /// Aquece o bolo, alterando sua temperatura para quente.
    /// </summary>
    /// <returns>Uma mensagem indicando o estado atual do bolo.</returns>
    public string Esquentar()
    {
        Temperatura = "quente";
        return $"O bolo de {Sabor} está {Temperatura}";
    }

    /// <summary>
    /// Resfria o bolo, alterando sua temperatura para frio.
    /// </summary>
    /// <returns>Uma mensagem indicando o estado atual do bolo.</returns>
    public string Esfriar()
    {
        Temperatura = "frio";
        return $"O bolo de {Sabor} está {Temperatura}";
    }

    /// <summary>
    /// Prepara o bolo para ser servido.
    /// </summary>
    /// <returns>Uma mensagem indicando que o bolo está sendo servido.</returns>
    public string Servir()
    {
        return $"Servindo um bolo de {Sabor} {Tamanho}";
    }
}
