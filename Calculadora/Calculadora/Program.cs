internal class Program
{
    private static void Main(string[] args)
    {
        float num1;
        float num2;
        float result;
        string answer;

        Console.WriteLine("Hello World! Welcome to the calculator program \n");
        Console.WriteLine("Please enter your first number");

        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your first number is " + num1 + "\n");

        Console.WriteLine("Please enter your second number");

        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your second number is " + num2 + "\n");

        Console.WriteLine("What type of operation would you like to do?");
        Console.WriteLine(" 'a' for addition \n 's' for subtraction \n 'm' for multiplication \n 'd' for division");

        answer = Console.ReadLine();
        if (answer == "a")
        {
            result = num1 + num2;
            
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else if (answer == "d")
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Invalid operation selected");
            return; // Optionally, you might want to exit the program if an invalid operation is selected.
        }
        Console.WriteLine("The result is " + result);
    }
}