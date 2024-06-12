# Adivinhe-Numero

# Jogo de Adivinhação

Este é um programa simples em C# que implementa um jogo de adivinhação. O programa gera um número aleatório entre 1 e 100 e solicita ao usuário que tente adivinhar esse número. O usuário recebe dicas sobre se sua tentativa foi muito alta, muito baixa ou correta.

## Funcionalidades Principais

### Geração do Número Aleatório

O programa utiliza a classe `Random` para gerar um número aleatório entre 1 e 100, inclusive:

```csharp
Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
```

### Loop de Adivinhação

O programa continua solicitando ao usuário que faça tentativas até que o número correto seja adivinhado. Isso é realizado com um loop `while`:

```csharp
while (!acertou)
{
    // Código de adivinhação
}
```

### Verificação da Tentativa

Após cada tentativa do usuário, o programa verifica se o número digitado é maior, menor ou igual ao número aleatório gerado:

```csharp
if (tentativa < numeroAleatorio)
{
    Console.WriteLine("Tente um número maior.");
}
else if (tentativa > numeroAleatorio)
{
    Console.WriteLine("Tente um número menor.");
}
else
{
    // Caso o usuário tenha acertado
}
```

### Finalização do Jogo

Quando o usuário adivinha corretamente o número, o programa exibe uma mensagem de parabéns e encerra:

```csharp
Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
Console.WriteLine("Obrigado por jogar!");
```

## Variáveis Principais

- `numeroAleatorio`: Armazena o número aleatório gerado para ser adivinhado pelo usuário.
- `tentativas`: Conta o número de tentativas que o usuário fez para adivinhar o número correto.
- `acertou`: Indica se o usuário adivinhou corretamente o número (true) ou não (false).

## Fluxo do Programa

1. O programa gera um número aleatório entre 1 e 100.
2. O programa solicita ao usuário que insira uma tentativa.
3. O usuário faz uma tentativa.
4. O programa fornece feedback com base na tentativa do usuário.
5. Os passos 2-4 se repetem até que o usuário adivinhe corretamente o número.
6. O programa exibe uma mensagem de parabéns e encerra.

Espero que essa documentação ajude a entender o funcionamento do programa!
