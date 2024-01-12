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
        public void StartGame()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
        }
    }
}
