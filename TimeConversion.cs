using System;
using System.Linq;

public class TimeConversion
{
    public void RunProgram()
    {
        string time = Console.ReadLine();
        var timeSplit = time.Split(':');
        var hour = timeSplit[0];
        
        var format = timeSplit[2].Substring(timeSplit[2].Length-2);
        if(format == "PM")
        {
            if(hour != "12")
                hour = (12 + Convert.ToInt32(timeSplit[0])).ToString();
        }
        else
        {
            if(hour == "12")
                hour = "00";
            else
                hour = timeSplit[0];
        }

        timeSplit[2] = timeSplit[2].Substring(0, 2);
        
        Console.WriteLine(String.Format("{0}:{1}:{2}", hour, timeSplit[1], timeSplit[2]));
    }
}