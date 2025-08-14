using System;
using System.Collections.Generic;
using System.Globalization;


abstract class Activity
{
    private DateTime _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = DateTime.ParseExact(date, "dd MMM yyyy", CultureInfo.InvariantCulture);
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMM yyyy");
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({GetMinutes()} min): " + $"Distance {GetDistance():0.0} km, " + $"Speed: {GetSpeed():0.0} kph, " + $"Pace: {GetPace():0.00} min per km";
    }
}