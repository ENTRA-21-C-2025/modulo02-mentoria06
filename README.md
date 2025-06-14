# modulo02-mentoria06
## Programação Orientada a Objetos: Classes, Métodos, Atributos

### O que é Programação Orientada a Objetos? (Explicação Simples)

Imagine que você está construindo uma casa:
- Uma Classe é como a planta da casa
- Um Objeto é a casa construída
- Os Atributos são as características da casa (cor, tamanho, número de quartos)
- Os Métodos são as ações que a casa pode fazer (abrir porta, acender luz)

### Os 4 Pilares da Programação Orientada a Objetos

#### 1. Encapsulamento (Proteção)
**Analogia**: Pense em um carro
- Você não precisa saber como o motor funciona para dirigir
- Você usa o volante, pedais e câmbio (interface pública)
- O motor, transmissão e sistema elétrico ficam escondidos (privados)

```csharp
public class Carro
{
    // Privado - ninguém pode acessar diretamente
    private string _combustivel;
    private double _nivelCombustivel;

    // Público - interface para o mundo exterior
    public void Abastecer(double litros)
    {
        if (litros > 0)
        {
            _nivelCombustivel += litros;
            Console.WriteLine($"Abastecido: {litros} litros");
        }
    }

    public double VerificarCombustivel()
    {
        return _nivelCombustivel;
    }
}
```

#### 2. Herança (Reutilização)
**Analogia**: Pense em uma família
- Os filhos herdam características dos pais
- Podem ter características próprias também
- Podem sobrescrever algumas características dos pais

```csharp
// Classe pai
public class Animal
{
    public string Nome { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico");
    }
}

// Classe filha
public class Cachorro : Animal
{
    // Sobrescreve o método do pai
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }

    // Método próprio do cachorro
    public void AbanarRabo()
    {
        Console.WriteLine("Abanando o rabo!");
    }
}
```

#### 3. Polimorfismo (Flexibilidade)
**Analogia**: Pense em um controle remoto
- O botão de ligar funciona diferente para cada aparelho
- TV: liga a tela
- Ar-condicionado: liga o compressor
- Mas todos usam o mesmo botão!

```csharp
// Interface comum
public interface IAparelho
{
    void Ligar();
}

// Diferentes implementações
public class TV : IAparelho
{
    public void Ligar()
    {
        Console.WriteLine("TV ligando...");
        Console.WriteLine("Mostrando imagem");
    }
}

public class ArCondicionado : IAparelho
{
    public void Ligar()
    {
        Console.WriteLine("Ar-condicionado ligando...");
        Console.WriteLine("Iniciando refrigeração");
    }
}

// Uso polimórfico
public void LigarAparelho(IAparelho aparelho)
{
    aparelho.Ligar(); // Funciona para qualquer aparelho!
}
```

#### 4. Abstração (Simplificação)
**Analogia**: Pense em um celular
- Você não precisa saber como funciona internamente
- Você só precisa saber usar os botões e a tela
- Os detalhes complexos ficam escondidos

```csharp
// Classe abstrata - define o que deve existir
public abstract class Smartphone
{
    // Método que todas as classes filhas devem implementar
    public abstract void FazerLigacao(string numero);
    
    // Método comum a todos os smartphones
    public void EnviarMensagem(string numero, string texto)
    {
        Console.WriteLine($"Enviando mensagem para {numero}: {texto}");
    }
}

// Implementação concreta
public class IPhone : Smartphone
{
    public override void FazerLigacao(string numero)
    {
        Console.WriteLine($"iPhone ligando para {numero}");
        // Código específico do iPhone
    }
}
```

### Resumo dos Pilares

| Pilar | O que é? | Analogia | Benefício |
|-------|----------|----------|-----------|
| **Encapsulamento** | Esconde detalhes internos | Carro: você só usa o volante | Segurança e organização |
| **Herança** | Reutiliza código existente | Família: filhos herdam dos pais | Reutilização de código |
| **Polimorfismo** | Mesma interface, comportamentos diferentes | Controle remoto: mesmo botão, ações diferentes | Flexibilidade |
| **Abstração** | Simplifica a complexidade | Celular: você só usa o que precisa | Simplicidade |

### Dicas Práticas para Iniciantes

1. **Encapsulamento**:
   - Comece sempre com atributos privados
   - Use propriedades para controlar o acesso
   - Exponha apenas o necessário

2. **Herança**:
   - Use quando houver relação "é um" (ex: Cachorro é um Animal)
   - Evite herança muito profunda
   - Prefira composição quando possível

3. **Polimorfismo**:
   - Use interfaces para definir contratos
   - Permita que diferentes classes implementem o mesmo comportamento
   - Facilita a manutenção e extensão

4. **Abstração**:
   - Foque no que é importante
   - Esconda detalhes complexos
   - Use classes abstratas e interfaces

### Conceitos Fundamentais

#### Classes e Objetos
Uma Classe é um modelo que define como criar objetos. É como uma receita que diz:
- Quais características o objeto terá (atributos)
- O que o objeto pode fazer (métodos)

```csharp
// Exemplo de uma classe
public class Carro
{
    // Atributos (características)
    public string Marca;
    public string Modelo;
    public int Ano;

    // Método (ação)
    public void Ligar()
    {
        Console.WriteLine("Carro ligado!");
    }
}

// Criando um objeto (instância)
Carro meuCarro = new Carro();
meuCarro.Marca = "Toyota";
meuCarro.Modelo = "Corolla";
meuCarro.Ano = 2023;
meuCarro.Ligar();
```

### Modificadores de Acesso

#### O que são Modificadores de Acesso?
São palavras-chave que controlam quem pode ver e usar partes do seu código:

#### Tabela de Modificadores de Acesso

| Modificador | Descrição | Exemplo de Uso | Quando Usar |
|------------|-----------|----------------|-------------|
| **public** | Acesso total, qualquer classe pode ver e usar | `public string Nome;` | Quando o atributo/método precisa ser acessível por qualquer classe |
| **private** | Acesso restrito, só a própria classe pode ver e usar | `private string Senha;` | Para atributos/métodos internos da classe que não devem ser acessados externamente |
| **protected** | Acesso para a própria classe e classes filhas | `protected string Documento;` | Quando você quer que classes filhas tenham acesso, mas outras classes não |
| **internal** | Acesso para classes do mesmo projeto | `internal string Configuracao;` | Para compartilhar entre classes do mesmo projeto, mas não com projetos externos |
| **protected internal** | Combina protected e internal | `protected internal string Dados;` | Quando você quer que classes filhas e classes do mesmo projeto tenham acesso |
| **private protected** | Acesso para classes filhas do mesmo projeto | `private protected string Info;` | Quando você quer que apenas classes filhas do mesmo projeto tenham acesso |

#### Dicas de Uso dos Modificadores

1. **Regra de Ouro**: Comece com `private` e só torne público o que for realmente necessário
2. **Encapsulamento**: Use `private` para esconder detalhes de implementação
3. **Herança**: Use `protected` quando precisar que classes filhas acessem
4. **Projetos**: Use `internal` para compartilhar entre classes do mesmo projeto
5. **Segurança**: Quanto mais restritivo o modificador, mais seguro seu código

### Propriedades (GET e SET)

#### O que são Propriedades?
Propriedades são uma forma elegante de controlar o acesso aos atributos de uma classe:

```csharp
public class Pessoa
{
    // Propriedade com get e set
    private string _nome; // campo privado
    public string Nome
    {
        get { return _nome; } // lê o valor
        set { _nome = value; } // define o valor
    }

    // Propriedade auto-implementada
    public int Idade { get; set; }
}
```

#### Por que usar GET e SET?
1. **Controle de Acesso**: Você decide como os dados são lidos e modificados
2. **Validação**: Pode verificar se os dados são válidos antes de aceitá-los
3. **Encapsulamento**: Esconde a implementação interna

```csharp
public class ContaBancaria
{
    private double _saldo;
    
    public double Saldo
    {
        get { return _saldo; }
        set 
        {
            if (value >= 0) // Validação
                _saldo = value;
            else
                throw new Exception("Saldo não pode ser negativo");
        }
    }
}
```

### Funções e Métodos

#### O que é uma Função?
Uma função é um bloco de código que:
- Recebe dados (parâmetros)
- Processa esses dados
- Retorna um resultado

```csharp
// Função simples
public int Somar(int a, int b)
{
    return a + b;
}
```

#### O que é um Método?
Um método é uma função que pertence a uma classe:
- Pode acessar os atributos da classe
- Define o comportamento do objeto
- Pode ser chamado através do objeto

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public void MostrarResultado(int resultado)
    {
        Console.WriteLine($"O resultado é: {resultado}");
    }
}
```

### Estrutura do Projeto

```
modulo02-mentoria06/
├── Classe/
│   ├── ExemploClasse.cs (Exemplos de classes e objetos)
│   └── ExemploPropriedades.cs (Exemplos de propriedades)
├── Encapsulamento/
│   ├── ExemploEncapsulamento.cs (Exemplos de encapsulamento)
│   └── ExemploModificadores.cs (Exemplos de modificadores de acesso)
├── Abstracao/
│   ├── ExemploAbstracao.cs (Exemplos de abstração)
│   └── ExemploInterface.cs (Exemplos de interfaces)
├── Heranca/
│   ├── ExemploHeranca.cs (Exemplos de herança)
│   └── ExemploPolimorfismo.cs (Exemplos de polimorfismo)
├── Program.cs (Menu principal)
├── modulo02-mentoria06.csproj
└── README.md
```

### Arquivos do Projeto

#### Program.cs
Arquivo principal que contém o menu interativo do programa:
- Menu de navegação
- Gerenciamento de exemplos
- Interface com o usuário

#### Classe/
- **ExemploClasse.cs**: Demonstra a criação e uso de classes
- **ExemploPropriedades.cs**: Mostra o uso de propriedades com get/set

#### Encapsulamento/
- **ExemploEncapsulamento.cs**: Exemplos de encapsulamento de dados
- **ExemploModificadores.cs**: Demonstração dos modificadores de acesso

#### Abstracao/
- **ExemploAbstracao.cs**: Exemplos de classes abstratas
- **ExemploInterface.cs**: Demonstração de interfaces

#### Heranca/
- **ExemploHeranca.cs**: Exemplos de herança entre classes
- **ExemploPolimorfismo.cs**: Demonstração de polimorfismo

### Como Executar

1. Clone o repositório
2. Abra o projeto no Visual Studio ou VS Code
3. Execute o projeto
4. Use o menu interativo para ver os exemplos

### Tecnologias Utilizadas

- C#
- .NET
- Console Application

### Dicas Importantes para Iniciantes

1. **Classes**:
   - Comece definindo os atributos
   - Adicione métodos que façam sentido para o objeto
   - Use nomes descritivos
   - Mantenha a classe focada em uma responsabilidade

2. **Propriedades**:
   - Use propriedades ao invés de campos públicos
   - Implemente validação no set quando necessário
   - Use propriedades auto-implementadas para casos simples

3. **Modificadores de Acesso**:
   - Use private por padrão
   - Exponha apenas o necessário como public
   - Use protected quando precisar de herança
   - Use internal para compartilhar entre classes do projeto

4. **Métodos**:
   - Dê nomes que descrevam a ação
   - Mantenha métodos pequenos e focados
   - Use parâmetros para receber dados
   - Retorne valores quando fizer sentido

### Observações Finais

- Todos os exemplos são interativos
- O código inclui comentários explicativos
- Os exemplos são focados em situações do dia a dia
- O menu principal permite fácil navegação
- Cada exemplo demonstra conceitos diferentes
- O código segue as melhores práticas do C#
