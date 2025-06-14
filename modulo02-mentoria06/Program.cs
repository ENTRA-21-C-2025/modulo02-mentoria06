using modulo02_mentoria06.Heranca;
using modulo02_mentoria06.Abstracao;
using modulo02_mentoria06.Encapsulamento;
using modulo02_mentoria06.Classe;

/// <summary>
/// Programa principal que demonstra conceitos de Programação Orientada a Objetos (POO)
/// através de exemplos práticos de Herança, Abstração, Encapsulamento e Classes.
/// </summary>
/// <remarks>
/// O programa apresenta um menu interativo que permite ao usuário escolher entre
/// diferentes demonstrações de conceitos POO, cada uma implementada em seu próprio método.
/// </remarks>
bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Exemplos de Programação Orientada a Objetos ===");
    Console.WriteLine("1. Exemplo de Herança (Veículos)");
    Console.WriteLine("2. Exemplo de Abstração (Controles Remotos)");
    Console.WriteLine("3. Exemplo de Encapsulamento (Conta Bancária)");
    Console.WriteLine("4. Exemplo de Classe (Bolo)");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha uma opção: ");

    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.Clear();
        switch (opcao)
        {
            case 1:
                DemonstrarHeranca();
                break;
            case 2:
                DemonstrarAbstracao();
                break;
            case 3:
                DemonstrarEncapsulamento();
                break;
            case 4:
                DemonstrarClasse();
                break;
            case 0:
                continuar = false;
                Console.WriteLine("Encerrando o programa...");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        if (continuar)
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente...");
        Console.ReadKey();
    }
}

/// <summary>
/// Demonstra o conceito de Herança através de um exemplo com veículos (Carro e Moto).
/// </summary>
/// <remarks>
/// Este método permite ao usuário criar e interagir com objetos Carro e Moto,
/// demonstrando como classes derivadas herdam comportamentos e propriedades
/// de uma classe base (Veiculo). O usuário pode especificar características
/// como marca, modelo, ano e atributos específicos de cada tipo de veículo.
/// </remarks>
void DemonstrarHeranca()
{
    Console.WriteLine("=== Demonstração de Herança ===\n");
    
    Console.Write("Digite a marca do carro: ");
    string marcaCarro = Console.ReadLine() ?? "Toyota";
    
    Console.Write("Digite o modelo do carro: ");
    string modeloCarro = Console.ReadLine() ?? "Corolla";
    
    Console.Write("Digite o ano do carro: ");
    int anoCarro = int.TryParse(Console.ReadLine(), out int anoC) ? anoC : 2024;
    
    Console.Write("Digite o número de portas: ");
    int numPortas = int.TryParse(Console.ReadLine(), out int portas) ? portas : 4;

    var carro = new Carro(marcaCarro, modeloCarro, anoCarro, numPortas);
    Console.WriteLine($"\nCarro criado: {carro.MostrarInfo()}");
    Console.WriteLine(carro.Acelerar());
    Console.WriteLine(carro.AbrirPorta(1));
    Console.WriteLine(carro.Frear());

    Console.WriteLine("\n--- Demonstração com Moto ---");
    Console.Write("Digite a marca da moto: ");
    string marcaMoto = Console.ReadLine() ?? "Honda";
    
    Console.Write("Digite o modelo da moto: ");
    string modeloMoto = Console.ReadLine() ?? "CB500";
    
    Console.Write("Digite o ano da moto: ");
    int anoMoto = int.TryParse(Console.ReadLine(), out int anoM) ? anoM : 2024;
    
    Console.Write("Digite as cilindradas: ");
    int cilindradas = int.TryParse(Console.ReadLine(), out int cil) ? cil : 500;

    var moto = new Moto(marcaMoto, modeloMoto, anoMoto, cilindradas);
    Console.WriteLine($"\nMoto criada: {moto.MostrarInfo()}");
    Console.WriteLine(moto.Acelerar());
    Console.WriteLine(moto.Empinar());
    Console.WriteLine(moto.Frear());
}

/// <summary>
/// Demonstra o conceito de Abstração através de controles remotos (TV e Ar Condicionado).
/// </summary>
/// <remarks>
/// Este método ilustra como a abstração permite definir uma interface comum
/// (IControleRemoto) que pode ser implementada de diferentes maneiras.
/// Demonstra o uso de interfaces para definir contratos que classes concretas
/// devem seguir, permitindo polimorfismo e flexibilidade no código.
/// </remarks>
void DemonstrarAbstracao()
{
    Console.WriteLine("=== Demonstração de Abstração ===\n");
    
    var controleTV = new ControleTV();
    var controleAr = new ControleAr();

    Console.WriteLine("=== Controle de TV ===");
    Console.WriteLine(controleTV.Ligar());
    Console.Write("Digite o volume desejado (0-100): ");
    if (int.TryParse(Console.ReadLine(), out int volume))
    {
        Console.WriteLine(controleTV.Ajustar(volume));
    }
    Console.WriteLine(controleTV.Desligar());

    Console.WriteLine("\n=== Controle de Ar Condicionado ===");
    Console.WriteLine(controleAr.Ligar());
    Console.Write("Digite a temperatura desejada (16-30): ");
    if (int.TryParse(Console.ReadLine(), out int temperatura))
    {
        Console.WriteLine(controleAr.Ajustar(temperatura));
    }
    Console.WriteLine(controleAr.Desligar());
}

/// <summary>
/// Demonstra o conceito de Encapsulamento através de uma conta bancária.
/// </summary>
/// <remarks>
/// Este método mostra como o encapsulamento protege os dados internos de uma classe
/// (ContaBanco) através de propriedades e métodos controlados. Demonstra:
/// - Proteção de dados (saldo)
/// - Validação de operações (depósito e saque)
/// - Controle de acesso (senha)
/// - Interface pública bem definida
/// </remarks>
void DemonstrarEncapsulamento()
{
    Console.WriteLine("=== Demonstração de Encapsulamento ===\n");
    
    Console.Write("Digite o nome do titular da conta: ");
    string nome = Console.ReadLine() ?? "João Silva";
    
    Console.Write("Digite o saldo inicial: ");
    decimal saldoInicial = decimal.TryParse(Console.ReadLine(), out decimal saldo) ? saldo : 1000;

    var conta = new ContaBanco(nome, saldoInicial);
    Console.WriteLine($"\nConta criada para: {conta.Nome}");
    Console.WriteLine(conta.VerSaldo());

    Console.Write("\nDigite o valor para depósito: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
    {
        Console.Write("Digite a senha (padrão: 1234): ");
        string senha = Console.ReadLine() ?? "1234";
        Console.WriteLine(conta.Depositar(valorDeposito, senha));
    }

    Console.WriteLine(conta.VerSaldo());

    Console.Write("\nDigite o valor para saque: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine() ?? "1234";
        Console.WriteLine(conta.Sacar(valorSaque, senha));
    }

    Console.WriteLine(conta.VerSaldo());
}

/// <summary>
/// Demonstra o conceito de Classe através de um exemplo de Bolo.
/// </summary>
/// <remarks>
/// Este método ilustra como uma classe pode encapsular dados (propriedades)
/// e comportamentos (métodos) relacionados a um objeto do mundo real.
/// Demonstra a criação e manipulação de um objeto Bolo com suas
/// características e ações específicas.
/// </remarks>
void DemonstrarClasse()
{
    Console.WriteLine("=== Demonstração de Classe ===\n");
    
    Console.Write("Digite o sabor do bolo: ");
    string sabor = Console.ReadLine() ?? "chocolate";
    
    Console.Write("Digite o tamanho do bolo (pequeno/médio/grande): ");
    string tamanho = Console.ReadLine() ?? "médio";

    var bolo = new Bolo(sabor, tamanho);
    Console.WriteLine($"\nBolo criado: {bolo.Servir()}");
    Console.WriteLine(bolo.Esquentar());
    Console.WriteLine(bolo.Esfriar());
}
