using System;

public class Car : Vehicle
{
    private int passengers;

    public Car(int p)
    {
        passengers = p;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passenger");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed = {speed}, Fuel = {fuel}, Passengers = {passengers}");
    }
}
