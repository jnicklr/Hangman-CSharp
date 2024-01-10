using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Player
    {
        public Player(string name, int life)
        {
            Name = name;
            Life = life;
        }

        public string Name { get; set; }
        public int Life { get; set; }
    }
}
