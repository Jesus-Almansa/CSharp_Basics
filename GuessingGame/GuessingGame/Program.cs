internal class Program
{
    private static void Main(string[] args)
    {
        bool isCorrectGuess = false;
        Random random = new Random();

        int randomNum = random.Next(0, 11);

        Console.WriteLine("Welcome to the guess game, guess the number");
        Console.WriteLine("Choose a number between 1 and 10");
        Console.WriteLine("If you guess you win");

        while (!isCorrectGuess)
        {
            Console.WriteLine("Please enter your guess.");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess > randomNum)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < randomNum)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("You win!");
                isCorrectGuess = true;
            }
        }
    }
}