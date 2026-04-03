using System;

public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public void DriveCar(Car targetCar)
    {
        Console.WriteLine($"{_name} tries to start the {targetCar.Model}...");

        if (targetCar.StartEngine())
        {
            Console.WriteLine("Success! The car is now running.");
        }
        else
        {
            Console.WriteLine("Failed. There is not enough fuel.");
        }
    }
}