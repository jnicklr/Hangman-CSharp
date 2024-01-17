using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangman.Models;
using Hangman.UI;

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

        private bool IsGuessInList(List<char> list, char userChoice)
        {
            return list.Any(guess => guess == userChoice);
        }

        private void BlankListUpdate(char[] blankWord, char userChoice, string word, bool canUpdate)
        {
            if (canUpdate)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (userChoice == word[i])
                    {
                        blankWord[i] = userChoice;
                    }
                }
            }
        }

        private void HitValidator(bool hit)
        {
            if (!hit)
            {
                player.LoseLife();
            }
            else
            {
                player.Points += 1;
            }
        }

        private void GameLoop()
        {
            char userChoice;
            bool hit = false;

            string word = "banana";
            int wordLength = word.Length;

            char[] blankWord = WordGenerator.GenerateBlanks(wordLength);
            List<char> uniqueLetters = WordGenerator.GetUniqueChars(word);
            List<char> userGuesses = new List<char>();

            while (player.GetLife() > 0 && player.Points != uniqueLetters.Count) {

                ConsoleUI.GameScreen(player.GetLife(), String.Join("", blankWord), String.Join("", userGuesses), player.Points);

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

                if (IsGuessInList(userGuesses, userChoice) == false) // Verificando se a letra está repetida.
                {
                    hit = IsGuessInList(uniqueLetters, userChoice); // Verificando se a letra está correta.
                }

                HitValidator(hit);
                BlankListUpdate(blankWord, userChoice, word, hit);

                userGuesses.Add(userChoice);
                hit = false;
            }
        }

        public void StartGame()
        {
            Console.Clear();
            PlayerInit();
            GameLoop();
        }
    }
}
