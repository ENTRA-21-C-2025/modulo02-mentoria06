namespace modulo02_mentoria06.Abstracao;

/// <summary>
/// Classe abstrata que define a interface base para controles remotos.
/// Esta classe serve como template para implementações específicas de controles remotos,
/// definindo os comportamentos básicos que todos os controles devem ter.
/// </summary>
public abstract class ControleRemotoAbstract
{
    /// <summary>
    /// Obtém ou define o estado de ligado/desligado do dispositivo.
    /// </summary>
    public bool Ligado { get; set; }

    /// <summary>
    /// Liga o dispositivo controlado.
    /// </summary>
    /// <returns>Uma mensagem indicando o resultado da operação.</returns>
    public abstract string Ligar();

    /// <summary>
    /// Desliga o dispositivo controlado.
    /// </summary>
    /// <returns>Uma mensagem indicando o resultado da operação.</returns>
    public abstract string Desligar();

    /// <summary>
    /// Ajusta um parâmetro específico do dispositivo (como volume ou temperatura).
    /// </summary>
    /// <param name="valor">O valor a ser ajustado. O significado e a faixa de valores válidos
    /// dependem da implementação específica.</param>
    /// <returns>Uma mensagem indicando o resultado do ajuste.</returns>
    public abstract string Ajustar(int valor);
}
