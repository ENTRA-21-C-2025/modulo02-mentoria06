namespace modulo02_mentoria06.Abstracao;

/// <summary>
/// Implementação de controle remoto específico para ar condicionado.
/// Esta classe gerencia o controle de um ar condicionado, permitindo ligar, desligar
/// e ajustar a temperatura. A temperatura é mantida em uma escala de 16°C a 30°C.
/// </summary>
public class ControleAr : ControleRemotoAbstract
{
    /// <summary>
    /// Armazena o valor atual da temperatura do ar condicionado.
    /// O valor é mantido entre 16°C e 30°C.
    /// </summary>
    private int temperatura;

    /// <summary>
    /// Inicializa uma nova instância do controle de ar condicionado.
    /// A temperatura é inicializada em 25°C.
    /// </summary>
    public ControleAr()
    {
        temperatura = 25;
    }

    /// <summary>
    /// Liga o ar condicionado e retorna uma mensagem de confirmação.
    /// </summary>
    /// <returns>Mensagem indicando que o ar condicionado foi ligado.</returns>
    public override string Ligar()
    {
        Ligado = true;
        return "Ar condicionado ligado!";
    }

    /// <summary>
    /// Desliga o ar condicionado e retorna uma mensagem de confirmação.
    /// </summary>
    /// <returns>Mensagem indicando que o ar condicionado foi desligado.</returns>
    public override string Desligar()
    {
        Ligado = false;
        return "Ar condicionado desligado!";
    }

    /// <summary>
    /// Ajusta a temperatura do ar condicionado para o valor especificado.
    /// O valor é limitado entre 16°C e 30°C.
    /// </summary>
    /// <param name="valor">A temperatura desejada em graus Celsius (16-30).</param>
    /// <returns>
    /// Uma mensagem indicando a nova temperatura ou um aviso se o ar condicionado estiver desligado.
    /// </returns>
    public override string Ajustar(int valor)
    {
        if (!Ligado)
        {
            return "Ar condicionado está desligado!";
        }

        temperatura = Math.Max(16, Math.Min(30, valor));
        return $"Temperatura ajustada para {temperatura}°C";
    }
}
