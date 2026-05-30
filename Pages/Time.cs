using System;

public class Time
{
    public static int TimeCreation() 
    {
        DateTime pastDate = new DateTime(2026, 5, 30); 
        DateTime today = DateTime.Today;
        TimeSpan difference = today - pastDate;
        int daysPassed = difference.Days;

        return difference.Days; 

    }
}
