# GamerProfile (gamer-profile-xunit)

Projeto desenvolvido para a disciplina de **Garantia da Qualidade de Software** (Gestão e Qualidade de Software), com o objetivo de praticar testes unitários com **xUnit** em uma solução **.NET 10**.

## Propósito do sistema

O **GamerProfile** simula um pequeno serviço de cadastro de jogadores. A classe `PerfilJogadorService` (projeto `GamerProfile.App`) reúne três regras de negócio simples, cada uma com um tipo de retorno diferente:

| Método | Retorno | O que faz |
|--------|---------|-----------|
| `GerarTagUsuario(string nickname, string codigo)` | `string` | Concatena o nickname e o código com `#`. Ex.: `"Aragorn"` e `"1042"` geram `"Aragorn#1042"`. |
| `CalcularXPTotal(int xpFase1, int xpFase2)` | `int` | Soma o XP de duas fases e aplica um bônus fixo de 100 pontos. Ex.: `200` e `300` geram `600`. |
| `EEligivelParaRanked(int nivelJogador)` | `bool` | Retorna `true` se o nível for maior ou igual a 15; caso contrário, `false`. |

## Estrutura da solução

```
GamerProfile/
├── GamerProfile.sln
├── GamerProfile.App/        # Código de produção (PerfilJogadorService)
└── GamerProfile.Tests/      # Testes unitários com xUnit
```

## Testes unitários realizados

Os testes ficam em `GamerProfile.Tests/PerfilJogadorServiceTests.cs` e usam o atributo `[Fact]`. Há um teste para cada tipo de retorno:

1. **Teste de string:** valida se `GerarTagUsuario` gera a formatação correta, usando `Assert.Equal("Nickname#0000", resultado)`.
2. **Teste de int:** valida se `CalcularXPTotal` soma as duas fases e aplica o bônus de 100 pontos, usando `Assert.Equal(valorEsperado, resultado)`.
3. **Teste de bool:** valida a regra de elegibilidade para partidas ranqueadas, usando `Assert.True(...)` para níveis a partir de 15 e `Assert.False(...)` para níveis abaixo de 15.

## Como executar

### Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download) ou superior
- [Git](https://git-scm.com/)

Para conferir a versão instalada do .NET:

```bash
dotnet --version
```

### Clonar o repositório

```bash
git clone https://github.com/marlon-II/gamer-profile-xunit.git
cd gamer-profile-xunit
```

### Executar os testes

Na raiz da solução (pasta onde está o arquivo `GamerProfile.sln`), rode:

```bash
dotnet test
```

O resultado esperado é que os 3 testes sejam aprovados:

```
Aprovado! – Com falha: 0, Aprovado: 3, Ignorado: 0, Total: 3
```

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.

#### Aluno: Marlon Andrade Bartoli
#### RA: 4251920432
