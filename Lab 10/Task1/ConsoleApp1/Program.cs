using System;

class Program
{
    private int data;
    private static int counter = 0;

    public Program()
    {
        counter++;
        Console.WriteLine($"Constructor Called | Alive Objects = {counter}");
    }

    ~Program()
    {
        counter--;
        Console.WriteLine($"Object Destroyed | Alive Objects = {counter}");
    }

    public void set_data(int x)
    {
        data = x;
    }

    public void show_data()
    {
        Console.WriteLine($"Data = {data}");
    }

    static void Main(string[] args)
    {
        createObjects();       // Program objects are created+used inside this function
                               // then go out of scope BEFORE ReadLine

        GC.Collect();          // destructor will run HERE
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void createObjects()
    {
        Program p1 = new Program();
        Program p2 = new Program();
        Program p3 = new Program();

        p1.set_data(10);
        p2.set_data(20);
        p3.set_data(30);

        p1.show_data();
        p2.show_data();
        p3.show_data();
    }
}
