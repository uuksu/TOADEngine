using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOADEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAdventureGame newTextAdventureGame;

            if (args.Length == 1)
            {
                newTextAdventureGame = new TextAdventureGame(args[0], false);
            }

            if (args.Length == 2 && args[1] == "-debug")
            {
                newTextAdventureGame = new TextAdventureGame(args[0], true);
            }
                
        }
    }
}
