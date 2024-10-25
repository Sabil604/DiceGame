using System;

namespace Dice_game
{
     class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerpoints = 0;
            int enemypoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerpoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemypoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player: " + playerpoints + ". Enemy : " + enemypoints + ".");
                Console.WriteLine();
            }
            if(playerpoints > enemypoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerpoints < enemypoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a Draw!");
            }

            Console.ReadKey();
        }
    }
}
