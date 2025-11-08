using System;

public class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int weight)
    {
        cargoWeight = weight;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine("Truck is moving with cargo");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed = {speed}, Fuel = {fuel}, Cargo = {cargoWeight}");
    }
}
