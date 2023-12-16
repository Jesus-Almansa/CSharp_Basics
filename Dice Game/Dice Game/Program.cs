using System;
internal class Dice_Game
{
    private static void Main(string[] args)
    {
        int playerRandomNum;
        int enemyRandomNum;
        Random random = new Random();

        int playerPoints = 0;
        int enemyPoints = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Press any button to role the dice");
            Console.ReadKey();

            playerRandomNum = random.Next(1, 7);
            Console.WriteLine("You rolled a " + playerRandomNum);

            Console.WriteLine("...");
            System.Threading.Thread.Sleep(500);

            enemyRandomNum = random.Next(1, 7);
            Console.WriteLine("AI rolled a " + enemyRandomNum);

            if (playerRandomNum > enemyRandomNum)
            {
                playerPoints++;
                Console.WriteLine("Player WINS this round \n");
            }
            else if (playerRandomNum < enemyRandomNum)
            {
                enemyPoints++;
                Console.WriteLine("AI WINS this round \n");
            }
            else
            {
                Console.WriteLine("DRAW \n");
            }
            Console.WriteLine("The score is now - Player : " + playerPoints + ". AI : " + enemyPoints + ".");
        }
        if (playerPoints > enemyPoints)
        {
            Console.WriteLine("Player WINS THE GAME \n");
            Console.WriteLine("Total score " + playerPoints);
        }
        else if (playerPoints < enemyPoints)
        {
            Console.WriteLine("AI WINS THE GAME \n");
            Console.WriteLine("Total score " + enemyPoints);
        }
        else
        {
            Console.WriteLine("THE GAME ENDS AS DRAW");
        }
        
    }
}