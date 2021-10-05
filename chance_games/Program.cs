using System;

namespace chance_games
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int card = rnd.Next(52);     // creates a number between 0 and 51
            int bjcard = rnd.Next(1,11);     // creates a number between 1 and 10

            Console.WriteLine("Dice: "+dice);
            Console.WriteLine("Card: " + card);
            Console.WriteLine("Black Jack Card: " + bjcard);
        }
    }
}
