using System;
using System.Collections.Generic;
using System.Globalization;

class Running : Activity
{
    private double _distanceKm;

    public Running(string date, double minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (_distanceKm / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distanceKm;
    }
}