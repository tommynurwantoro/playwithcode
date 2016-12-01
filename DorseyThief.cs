using System;
using System.Linq;

public class DorseyThief
{
    public void RunProgram()
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(arr_temp[0]);
        int x = Convert.ToInt32(arr_temp[1]);

        int[] v = new int[n];
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr_temp = Console.ReadLine().Split(' ');
            v[i] = Convert.ToInt32(arr_temp[0]);
            a[i] = Convert.ToInt32(arr_temp[1]);
        }
        
        

        // Console.WriteLine(result);
    }

    public void Calculate(int n, int x, int[] v, int i)
    {
        if(i+1 == n)
            return;
        var totalValue = v[i] + v[i+1];
        if(totalValue != x)
        {
            Calculate(n, x, v, i+1);
        }
    }
}