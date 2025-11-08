public static class MathHelper
{
    public static long Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers");

        if (number == 0 || number == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}

public class LoopDemonstrator
{
    public void DemonstrateForLoop()
    {
        Console.WriteLine("For Loop (1 to 10):");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");
    }

    public void DemonstrateForeachLoop()
    {
        Console.WriteLine("Foreach Loop (1 to 10):");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }

    public void DemonstrateDoWhileLoop()
    {
        Console.WriteLine("Do-While Loop - Type 'exit' to stop:");
        string userInput;

        do
        {
            Console.Write("Enter something: ");
            userInput = Console.ReadLine();
            if (userInput?.ToLower() != "exit")
            {
                Console.WriteLine($"You entered: {userInput}");
            }
        } while (userInput?.ToLower() != "exit");

        Console.WriteLine("Do-While loop ended!\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">> Loops and Functions Demonstration\n");

        LoopDemonstrator demonstrator = new LoopDemonstrator();

        demonstrator.DemonstrateForLoop();
        demonstrator.DemonstrateForeachLoop();
        demonstrator.DemonstrateDoWhileLoop();

        DemonstrateFactorialCalculation();
    }
    static void DemonstrateFactorialCalculation()
    {
        Console.WriteLine(">> Factorial Calculation");
        while (true)
        {
            Console.Write("Enter a number to calculate factorial (or 'quit' to exit): ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;
            try
            {
                int number = Convert.ToInt32(input);
                long factorial = MathHelper.Factorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number!\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large! Please try a smaller number.\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }
    }
}