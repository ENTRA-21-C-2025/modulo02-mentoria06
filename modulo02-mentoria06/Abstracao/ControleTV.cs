namespace modulo02_mentoria06.Abstracao;

/// <summary>
/// Implementação de controle remoto específico para TV.
/// Esta classe gerencia o controle de uma TV, permitindo ligar, desligar e ajustar o volume.
/// O volume é mantido em uma escala de 0 a 100.
/// </summary>
public class ControleTV : ControleRemotoAbstract
{
    /// <summary>
    /// Armazena o valor atual do volume da TV.
    /// O valor é mantido entre 0 e 100.
    /// </summary>
    private int volume;

    /// <summary>
    /// Inicializa uma nova instância do controle de TV.
    /// O volume é inicializado em 0.
    /// </summary>
    public ControleTV()
    {
        volume = 0;
    }

    /// <summary>
    /// Liga a TV e retorna uma mensagem de confirmação.
    /// </summary>
    /// <returns>Mensagem indicando que a TV foi ligada.</returns>
    public override string Ligar()
    {
        Ligado = true;
        return "TV ligada!";
    }

    /// <summary>
    /// Desliga a TV e retorna uma mensagem de confirmação.
    /// </summary>
    /// <returns>Mensagem indicando que a TV foi desligada.</returns>
    public override string Desligar()
    {
        Ligado = false;
        return "TV desligada!";
    }

    /// <summary>
    /// Ajusta o volume da TV para o valor especificado.
    /// O valor é limitado entre 0 e 100.
    /// </summary>
    /// <param name="valor">O valor desejado para o volume (0-100).</param>
    /// <returns>
    /// Uma mensagem indicando o novo volume ou um aviso se a TV estiver desligada.
    /// </returns>
    public override string Ajustar(int valor)
    {
        if (!Ligado)
        {
            return "TV está desligada!";
        }

        volume = Math.Max(0, Math.Min(100, valor));
        return $"Volume ajustado para {volume}";
    }
}
