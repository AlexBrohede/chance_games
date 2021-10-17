using System;

namespace chance_games
{
    class MainClass
    {
        private static Random rnd;
        public static int DrawCard(string user)
        {
            int card = rnd.Next(1, 10);
            Console.WriteLine($"{user} drew {card}");
            return card;
        }
        public static void Main(string[] args)
        {
            rnd = new Random();

            int Menu1 = 0;

            while (Menu1 != 4)
            {
                Console.WriteLine("1 BlackJack \n2 Game not found \n3 Game not found \n4 Quit");
                Menu1 = int.Parse(Console.ReadLine());
                if (Menu1 == 1)
                {
                    Console.Clear();

                    int player = 0; int house = 0; bool continueToDraw = false;

                    //House draws twice
                    house += DrawCard("house");
                    house += DrawCard("house");
                    Console.WriteLine($"House now has {house}");
                    //player draws twice
                    player += DrawCard("player");
                    player += DrawCard("player");
                    Console.WriteLine($"Player now has {player}");

                    Console.WriteLine($"Draw \n1 Yes/2 No");
                    int drawChoice = int.Parse(Console.ReadLine());
                    if (drawChoice == 1) { continueToDraw = true; }
                    else { continueToDraw = false; }

                    while (continueToDraw)
                    {
                        player += DrawCard("player");
                        Console.WriteLine($"Player now has {player}");
                        if (player > 21) { continueToDraw = false; }
                        else
                        {
                            Console.WriteLine($"Draw \n1 Yes/2 No");
                            drawChoice = int.Parse(Console.ReadLine());
                            if (drawChoice == 1) { continueToDraw = true; }
                            else { continueToDraw = false; }
                        }
                    }
                    while (house < player && player <= 21)
                    {
                        house += DrawCard("house");
                        Console.WriteLine($"House now has {house}");
                    }

                    if (player > 21) { Console.WriteLine("Player busted house wins"); }
                    else if (house > 21) { Console.WriteLine("House busted player wins"); }
                    else if (player > house) { Console.WriteLine("Player got more than house player wins"); }
                    else if (house > player) { Console.WriteLine("house got more than player house wins"); }
                    else { Console.WriteLine("Error"); }











                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Menu1 == 2)
                { }
                else if (Menu1 == 3)
                { }
                else if (Menu1 == 4) { Console.Clear(); Console.WriteLine("Stoping program"); }
            }

        }
    }
}
