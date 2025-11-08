using System;

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle();
        Vehicle c = new Car(4);
        Vehicle t = new Truck(2000);

        Vehicle[] arr = { v, c, t };

        foreach (Vehicle obj in arr)
        {
            obj.Drive();
            obj.ShowInfo();
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
