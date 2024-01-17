using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangman.Game;

namespace Hangman.UI
{
    public static class ConsoleUI
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|          Menu do Jogo          |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|      1 - Iniciar o Jogo        |");
            Console.WriteLine("|      2 - Sair do Jogo          |");
            Console.WriteLine("|      3 - Adicionar Palavra     |");
            Console.WriteLine("|      4 - Visualizar Palavras   |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|      Digite sua opção:         |");
            Console.WriteLine("----------------------------------");
            Console.SetCursorPosition(25, 8);
        }

        public static void GameScreen(int life, string blank, string guesses, int points)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|             HANGMAN            |");
            Console.WriteLine("----------------------------------");
            StickmanStages(life);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Vidas: {life}");
            Console.WriteLine($"Palavra: {blank}");
            Console.WriteLine($"Chutes: {guesses}");
            Console.WriteLine($"Pontos: {points}");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite uma letra: ");
        }

        public static void OptionHandler(short option)
        {
            switch (option)
            {
                case 1:
                    HangmanGame game = new HangmanGame();
                    game.StartGame();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }

        public static void StickmanStages(int lifes)
        {
            switch (lifes)
            {
                case 0:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 1:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" /    |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 2:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 3:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 4:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 5:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 6:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
            }
        }
    }
}
