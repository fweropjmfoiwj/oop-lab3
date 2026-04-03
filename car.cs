using System;

public class Car
{
    private string _model;
    private int _year;
    private double _fuel;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public double Fuel
    {
        get { return _fuel; }
        set { _fuel = value; }
    }

    public Car(string model, int year, double fuel)
    {
        _model = model;
        _year = year;
        _fuel = fuel;
    }

    public bool StartEngine()
    {
        return _fuel >= 2.0;
    }
}