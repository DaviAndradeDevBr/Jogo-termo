# Jogo de Adivinhação (Termo) 🕵️‍♂️

## Introdução

Este projeto é um simulador do popular jogo "Termo", desenvolvido como um aplicativo de console em C#. O objetivo é desafiar o jogador a descobrir uma palavra secreta de 5 letras em um número limitado de tentativas, utilizando lógica e deduções baseadas em feedbacks visuais.

## Regras do Jogo 📜

1. **Objetivo**: Descobrir a palavra secreta de **5 letras** sorteada pelo sistema.
2. **Tentativas**: O jogador tem no máximo **5 chances** para acertar.
3. **Sorteio**: A palavra é escolhida aleatoriamente de um banco de dados interno a cada nova partida.
4. **Feedback de Cores**:
   - 🟩 **Verde**: A letra está correta e na posição exata.
   - 🟨 **Amarelo**: A letra existe na palavra, mas está na posição errada.
   - 🟥 **Vermelho**: A letra não existe na palavra secreta.
5. **Vitória**: Ocorre quando o jogador acerta todas as letras na posição correta antes de esgotar as tentativas.
6. **Derrota**: Ocorre caso o jogador não descubra a palavra após a 5ª tentativa.

## Diferenciais desta Versão 💎

- **Null Safety**: Implementação de tratamento para entradas nulas no `Console.ReadLine()`, evitando exceções no sistema.
- **Validação de Entrada**: O sistema verifica se a palavra possui exatamente 5 caracteres antes de processar a jogada, garantindo a integridade da lógica.
- **Feedback Visual Dinâmico**: Uso de cores nativas do terminal **ConsoleColor** para fornecer respostas imediatas ao jogador, facilitando a dedução da palavra secreta.
- **Versionamento Estruturado**: Projeto desenvolvido seguindo um cronograma de commits semânticos, facilitando o rastreio de cada funcionalidade (Interface, Validação, Lógica de Cores e Finalização).

## Instruções de Uso 💻

1.  Obtenha o código via clone de repositório ou download do arquivo `.zip`.
2.  Acesse o diretório raiz através do terminal.
3.  Utilize o comando abaixo para restaurar as dependências:
    ```bash
    dotnet restore
    ```
4.  Inicie a aplicação:
    ```bash
    dotnet run --project JogoTermo.ConsoleApp


## Requisitos de Sistema

.NET SDK 10.0 ou superior.