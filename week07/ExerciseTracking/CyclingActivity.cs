using System;
using System.Collections.Generic;
using System.Globalization;

class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, double minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * GetMinutes()) / 60; // convert speed from kph to km based on minutes
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }
}
