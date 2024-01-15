using System;
using System.Collections.Generic;
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
            Console.WriteLine("Digite o seu nome: ");
            player.Name = Console.ReadLine();
        }

        private void GameLoop()
        {
            string word = "banana";
            int wordLength = word.Length;
            string blankWord = "";

            for (int i = 0; i < wordLength; i++)
            {
                blankWord += "*";
            }

            Console.WriteLine(word);
            Console.WriteLine(blankWord);
        }

        public void StartGame()
        {
            PlayerInit();
            GameLoop();
        }
    }
}
