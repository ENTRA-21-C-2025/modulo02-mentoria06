namespace modulo02_mentoria06.Encapsulamento;

/// <summary>
/// Representa uma conta bancária com funcionalidades básicas de operações financeiras.
/// </summary>
/// <remarks>
/// Esta classe implementa o conceito de encapsulamento em C#, protegendo os dados sensíveis
/// (nome, saldo e senha) através de modificadores de acesso privados e fornecendo métodos
/// públicos para interagir com esses dados de forma segura.
/// 
/// Funcionalidades implementadas:
/// - Consulta de saldo
/// - Depósito de valores
/// - Saque de valores
/// - Alteração de senha
/// 
/// Características de segurança:
/// - Senha padrão inicial: "1234"
/// - Validação de senha em operações sensíveis
/// - Proteção contra valores negativos
/// - Verificação de saldo suficiente para saques
/// </remarks>
public class ContaBanco
{
    private string _nome;
    private decimal _saldo;
    private string _senha;

    /// <summary>
    /// Obtém o nome do titular da conta.
    /// </summary>
    public string Nome => _nome;

    /// <summary>
    /// Inicializa uma nova instância da classe ContaBanco.
    /// </summary>
    /// <param name="nome">Nome do titular da conta.</param>
    /// <param name="saldoInicial">Saldo inicial da conta. O padrão é 0.</param>
    /// <remarks>
    /// Ao criar uma nova conta, uma senha padrão "1234" é definida automaticamente.
    /// </remarks>
    public ContaBanco(string nome, decimal saldoInicial = 0)
    {
        _nome = nome;
        _saldo = saldoInicial;
        _senha = "1234"; 
    }

    /// <summary>
    /// Retorna o saldo atual da conta formatado em reais.
    /// </summary>
    /// <returns>Uma string contendo o saldo atual formatado como "Saldo atual: R$ X,XX".</returns>
    public string VerSaldo()
    {
        return $"Saldo atual: R$ {_saldo:F2}";
    }

    /// <summary>
    /// Realiza um depósito na conta.
    /// </summary>
    /// <param name="valor">Valor a ser depositado. Deve ser maior que zero.</param>
    /// <param name="senha">Senha da conta para autorização do depósito.</param>
    /// <returns>
    /// Uma mensagem indicando o resultado da operação:
    /// - "Depósito de R$ X,XX realizado com sucesso!" em caso de sucesso
    /// - "Senha incorreta!" se a senha estiver errada
    /// - "Valor inválido para depósito" se o valor for zero ou negativo
    /// </returns>
    public string Depositar(decimal valor, string senha)
    {
        if (senha != _senha)
        {
            return "Senha incorreta!";
        }

        if (valor > 0)
        {
            _saldo += valor;
            return $"Depósito de R$ {valor:F2} realizado com sucesso!";
        }

        return "Valor inválido para depósito";
    }

    /// <summary>
    /// Realiza um saque na conta.
    /// </summary>
    /// <param name="valor">Valor a ser sacado. Deve ser maior que zero e menor ou igual ao saldo disponível.</param>
    /// <param name="senha">Senha da conta para autorização do saque.</param>
    /// <returns>
    /// Uma mensagem indicando o resultado da operação:
    /// - "Saque de R$ X,XX realizado com sucesso!" em caso de sucesso
    /// - "Senha incorreta!" se a senha estiver errada
    /// - "Valor inválido para saque ou saldo insuficiente" se o valor for inválido ou exceder o saldo
    /// </returns>
    public string Sacar(decimal valor, string senha)
    {
        if (senha != _senha)
        {
            return "Senha incorreta!";
        }

        if (valor > 0 && valor <= _saldo)
        {
            _saldo -= valor;
            return $"Saque de R$ {valor:F2} realizado com sucesso!";
        }

        return "Valor inválido para saque ou saldo insuficiente";
    }

    /// <summary>
    /// Altera a senha da conta.
    /// </summary>
    /// <param name="senhaAtual">Senha atual da conta para validação.</param>
    /// <param name="novaSenha">Nova senha desejada. Deve ter pelo menos 4 caracteres.</param>
    /// <returns>
    /// Uma mensagem indicando o resultado da operação:
    /// - "Senha alterada com sucesso!" em caso de sucesso
    /// - "Senha atual incorreta!" se a senha atual estiver errada
    /// - "A nova senha deve ter pelo menos 4 caracteres" se a nova senha for muito curta
    /// </returns>
    public string MudarSenha(string senhaAtual, string novaSenha)
    {
        if (senhaAtual != _senha)
        {
            return "Senha atual incorreta!";
        }

        if (novaSenha.Length >= 4)
        {
            _senha = novaSenha;
            return "Senha alterada com sucesso!";
        }
        return "A nova senha deve ter pelo menos 4 caracteres";
    }
}
