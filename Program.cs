using Hangman.Game;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();
            game.StartGame();
        }
    }
}