namespace modulo02_mentoria06.Heranca;

/// <summary>
/// Classe que representa um carro, herdando características básicas de VeiculoPai
/// </summary>
public class Carro : VeiculoPai
{
    /// <summary>
    /// Número de portas do carro
    /// </summary>
    public int NumPortas { get; private set; }

    /// <summary>
    /// Construtor da classe Carro
    /// </summary>
    /// <param name="marca">Marca do carro</param>
    /// <param name="modelo">Modelo do carro</param>
    /// <param name="ano">Ano de fabricação</param>
    /// <param name="numPortas">Número de portas do carro</param>
    public Carro(string marca, string modelo, int ano, int numPortas) : base(marca, modelo, ano)
    {
        NumPortas = numPortas;
    }

    /// <summary>
    /// Simula a abertura de uma porta específica do carro
    /// </summary>
    /// <param name="numeroPorta">Número da porta a ser aberta</param>
    /// <returns>Mensagem informando se a porta foi aberta ou se não existe</returns>
    public string AbrirPorta(int numeroPorta)
    {
        if (numeroPorta >= 1 && numeroPorta <= NumPortas)
        {
            return $"Porta {numeroPorta} do {Marca} {Modelo} aberta";
        }
        return $"O {Marca} {Modelo} não tem porta {numeroPorta}";
    }

    /// <summary>
    /// Sobrescreve o método MostrarInfo para incluir o número de portas
    /// </summary>
    /// <returns>String formatada com informações do carro incluindo número de portas</returns>
    public override string MostrarInfo()
    {
        string infoBase = base.MostrarInfo();
        return $"{infoBase} - {NumPortas} portas";
    }
} 