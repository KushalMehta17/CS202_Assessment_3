using System;

public class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle()
    {
        speed = 50;
        fuel = 100;
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed = {speed}, Fuel = {fuel}");
    }
}
