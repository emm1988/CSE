using System;
using System.Collections.Generic;
using System.Globalization;using System;

class Program
{
    static void Main(string[] args)
    {
        string currentDate = DateTime.Now.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        List<Activity> activities = new List<Activity>
        {
            new Running(currentDate, 30, 5),
            new Cycling(currentDate, 45, 16),
            new Swimming(currentDate, 40, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}