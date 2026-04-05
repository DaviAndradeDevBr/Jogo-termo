using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoTermo.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // 1. Lista de palavras de 5 letras
        List<string> bancoDePalavras = new List<string>
        {
            "PROVA", "SABER", "VIVER", "FORTE", "PONTO", 
            "LUGAR", "FALAR", "MENTE", "NOITE", "PORTA", 
            "PLANO", "BRISA", "CALOR", "MUNDO", "PRATO",
            "TREINO", "LIVRO", "CAIXA", "RADIO", "CARRO"
        };

        // Sorteia a palavra secreta
        Random random = new Random();
        string palavraSecreta = bancoDePalavras[random.Next(bancoDePalavras.Count)].ToUpper();

        int limiteTentativas = 5;
        int tentativaAtual = 0;
        bool venceu = false;
    
    
        // 3. Loop principal do jogo
        while (tentativaAtual < limiteTentativas && !venceu)
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("    BEM VINDO AO JOGO DE ADIVINHAÇÃO   ");
            Console.WriteLine("============================================");
            Console.WriteLine($"Tentativa {tentativaAtual + 1} de {limiteTentativas}");
            Console.WriteLine("DICA: [Verde] correto | [Amarelo] Posição Errada | [Vermelho] Inexistente");
            Console.WriteLine("============================================\n");

            Console.Write("Digite seu palpite (5 letras): ");
            string palpite = Console.ReadLine()!.ToUpper().Trim();

            // Validação
            if (palpite.Length != 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERRO: A palavra deve ter exatamente 5 letras!");
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue; // Volta para o início do while sem gastar tentativa
            }

    
        }
    }   
}
