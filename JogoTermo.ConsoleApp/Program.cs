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
            "TREINO", "CORTE", "GRITO", "RADIO", "MOSCA"
        };

        // Sorteia a palavra secreta
        Random random = new Random();
        string palavraSecreta = bancoDePalavras[random.Next(bancoDePalavras.Count)].ToUpper();

        int limiteTentativas = 5;
        int tentativaAtual = 0;
        bool venceu = false;
    }
}
