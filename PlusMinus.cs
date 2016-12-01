using System;
using System.Linq;

public class PlusMinus
{
    public void RunProgram()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = arr_temp.Select(s => Convert.ToInt32(s)).ToArray();

        var pos = arr.Count(a => a > 0);
        var neg = arr.Count(a => a < 0);
        var zer = arr.Count(a => a == 0);

        Console.WriteLine((decimal)pos/n);
        Console.WriteLine((decimal)neg/n);
        Console.WriteLine((decimal)zer/n);
    }
}