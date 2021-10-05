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
            int bjcard = rnd.Next(1, 11);     // creates a number between 1 and 10

            Console.WriteLine("1 Dice \n2 Card \n3 BJcard");
            int Choice = int.Parse(Console.ReadLine());

            if (Choice == 1)
            {
                Console.WriteLine("Dice: " + dice);
            }
            else if (Choice == 2)
            {
                Console.WriteLine("Card: " + card);
            }
            else if (Choice == 3)
            {
                Console.WriteLine("Black Jack Card: " + bjcard);
            }
            else { Console.WriteLine($"{Choice} was not a option!"); }
        }
    }
}
