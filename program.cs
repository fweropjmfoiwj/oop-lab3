using System;

class Program
{
    static void Main()
    {
        Car myCar = new Car("Mazda", 2018, 1.5);
        Person driver = new Person("Alex");

        driver.DriveCar(myCar);

        Console.WriteLine("\nRefueling the car...\n");

        myCar.Fuel = 5.0;

        driver.DriveCar(myCar);

        Console.ReadLine();
    }
}