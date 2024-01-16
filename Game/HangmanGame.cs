using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangman.Models;

namespace Hangman.Game
{
    public class HangmanGame
    {
        public Player player = new Player();

        private void PlayerInit()
        {
            Console.Write("Digite o seu nome: ");
            player.Name = Console.ReadLine();
        }

        private void GameLoop()
        {
            char userChoice;
            int userPoints = 0;
            bool hit = false;

            string word = "banana";
            int wordLength = word.Length;

            char[] blankWord = new char[wordLength];

            for (int i = 0; i < wordLength; i++)
            {
                blankWord[i] = '*';
            }

            List<char> uniqueLetters = new List<char>();

            List<char> userGuesses = new List<char>();

            for (int i = 0; i < wordLength; i++)
            {
                if (!(uniqueLetters.Any(letter => letter == word[i])))
                {
                    uniqueLetters.Add(Convert.ToChar(word[i]));
                }
            }


            while (player.GetLife() > 0 && userPoints != uniqueLetters.Count) {
                Console.Clear();
                Console.WriteLine($"Vidas restantes: {player.GetLife()}");
                Console.WriteLine($"Palavra escondida: {String.Join("", blankWord)}");
                Console.WriteLine($"Letras: {String.Join("", uniqueLetters)}");
                Console.WriteLine($"Letras chutadas: {String.Join("", userGuesses)}");
                Console.WriteLine($"Pontos: {userPoints}");
                Console.WriteLine($"Quantidade de Letras: {uniqueLetters.Count}");
                Console.Write("Digite uma letra: ");

                try
                {
                    userChoice = Convert.ToChar(Console.ReadLine());
                } catch (FormatException ex)
                {
                    Console.WriteLine("Digite apenas uma letra!");
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();
                    continue;
                }

                if (userGuesses.Any(guess => guess == userChoice))
                {
                    hit = false;
                }
                else
                {
                    foreach (char letter in uniqueLetters)
                    {
                        if (userChoice == letter)
                        {
                            userPoints += 1;
                            hit = true;
                        }
                    }
                }

                if (!hit)
                {
                    player.LoseLife();
                } else
                {
                    for (int i = 0; i < wordLength; i++)
                    {
                        if (userChoice == word[i])
                        {
                            blankWord[i] = userChoice;
                        }
                    }
                }

                userGuesses.Add(userChoice);
                hit = false;
            }
        }

        public void StartGame()
        {
            PlayerInit();
            GameLoop();
        }
    }
}
