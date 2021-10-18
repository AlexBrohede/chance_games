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
            int playerBalance = 100;

            int Menu1 = 0;

            while (Menu1 != 4)
            {
                Console.WriteLine("1 BlackJack \n2 Player balance \n3 Pitty wheel \n4 Quit");
                Menu1 = int.Parse(Console.ReadLine());
                if (Menu1 == 1)
                {
                    Console.Clear();

                    int betAmount = 0;
                    int player = 0;
                    int house = 0;
                    bool continueToDraw = false;

                    Console.WriteLine($"player has {playerBalance}");
                    Console.WriteLine($"write bet amount");
                    betAmount = int.Parse(Console.ReadLine());
                    while (betAmount > playerBalance)
                    {
                        Console.WriteLine($"You can't bet {betAmount} you only have {playerBalance}\nNew bet amount");
                        betAmount = int.Parse(Console.ReadLine());
                    }
                    playerBalance -= betAmount;

                    //House draws twice
                    house += DrawCard("house");
                    house += DrawCard("house");
                    Console.WriteLine($"House now has {house}");
                    //player draws twice
                    player += DrawCard("player");
                    player += DrawCard("player");
                    Console.WriteLine($"Player now has {player}");
                    //ask player to draw
                    Console.WriteLine($"Draw \n1 Yes/2 No");
                    int drawChoice = int.Parse(Console.ReadLine());
                    if (drawChoice == 1)
                    {
                        continueToDraw = true;
                    }
                    else
                    {
                        continueToDraw = false;
                    }
                    while (continueToDraw)
                    {
                        Console.Clear();
                        player += DrawCard("player");
                        Console.WriteLine($"Player now has {player}");
                        Console.WriteLine($"house has {house}");
                        if (player > 21)
                        {
                            continueToDraw = false;
                        }
                        else
                        {
                            Console.WriteLine($"Draw \n1 Yes/2 No");
                            drawChoice = int.Parse(Console.ReadLine());
                            if (drawChoice == 1)
                            {
                                continueToDraw = true;
                            }
                            else
                            {
                                continueToDraw = false;
                            }
                        }
                    }
                    Console.Clear();
                    while (house < player && player <= 21)
                    {
                        house += DrawCard("house");
                        Console.WriteLine($"House now has {house}");
                    }
                    Console.WriteLine($"Player has {player}");

                    if (player > 21)
                    {
                        Console.WriteLine($"Player busted house wins \nYou lost {betAmount}");
                    }
                    else if (house > 21)
                    {
                        Console.WriteLine($"House busted player wins {betAmount}");
                        playerBalance += betAmount * 2;
                    }
                    else if (player > house)
                    {
                        Console.WriteLine($"Player got more than house player wins{betAmount}");
                        playerBalance += betAmount * 2;
                    }
                    else if (house >= player)
                    {
                        Console.WriteLine($"house got more or equal to the player house wins \nYou lost {betAmount}");
                    }
                    else { Console.WriteLine("Error"); }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Menu1 == 2)
                {
                    Console.WriteLine($"Player has {playerBalance}");

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Menu1 == 3)
                {
                    Console.WriteLine($"Pitty wheel pick a number after setting the limits \nPick the lowest value");
                    int lowRnd = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pick the high end");
                    int highRnd = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pick a number betweeen {lowRnd} and {highRnd}");
                    int guess = int.Parse(Console.ReadLine());
                    while (guess < lowRnd || guess > highRnd)
                    {
                        Console.WriteLine($"please pick a number between {lowRnd} and {highRnd}");
                        guess = int.Parse(Console.ReadLine());
                    }
                    int wheel = rnd.Next(lowRnd, highRnd);
                    if (wheel == guess)
                    {
                        Console.WriteLine($"Congratulations you won {highRnd - lowRnd}");
                        playerBalance += (highRnd - lowRnd);
                        Console.WriteLine($"you now have {playerBalance}");
                    }
                    else
                    {
                        Console.WriteLine("you lost and got nothing");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Menu1 == 4) { Console.Clear(); Console.WriteLine("Stoping program"); }
                else { Console.WriteLine("Error"); }
            }

        }
    }
}
