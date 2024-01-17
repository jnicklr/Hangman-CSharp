using Hangman.UI;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleUI.Menu();
                if (short.TryParse(Console.ReadLine(), out short option))
                {
                    ConsoleUI.OptionHandler(option);
                } else
                {
                    ConsoleUI.OptionHandler(0);
                }
            }
        }
    }
}