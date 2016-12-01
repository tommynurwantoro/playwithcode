using System;
using System.Linq;

public class BigSum
{
    public void RunProgram()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = arr_temp.Select(s => Convert.ToInt32(s)).ToArray();

        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result+= arr[i];
        }

        Console.WriteLine(result);
    }
}