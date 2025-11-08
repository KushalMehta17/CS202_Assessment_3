public class Calculator
{
    public double Number1 { get; set; }
    public double Number2 { get; set; }
    public Calculator(double num1, double num2)
    {
        Number1 = num1;
        Number2 = num2;
    }
    public double Add()
    {
        return Number1 + Number2;
    }

    public double Subtract()
    {
        return Number1 - Number2;
    }

    public double Multiply()
    {
        return Number1 * Number2;
    }

    public double Divide()
    {
        if (Number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero!");
        }
        return Number1 / Number2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Object-Oriented Calculator");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Calculator calc = new Calculator(num1, num2);

        double sum = calc.Add();
        double difference = calc.Subtract();
        double product = calc.Multiply();
        double quotient = calc.Divide();

        Console.WriteLine($"\nResults:");
        Console.WriteLine($"Addition: {sum}");
        Console.WriteLine($"Subtraction: {difference}");
        Console.WriteLine($"Multiplication: {product}");
        Console.WriteLine($"Division: {quotient:F2}");

        if (sum % 2 == 0)
        {
            Console.WriteLine($"The sum = {sum} is EVEN");
        }
        else
        {
            Console.WriteLine($"The sum = {sum} is ODD");
        }
    }
}