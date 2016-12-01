using System;
using System.Linq;

public class CircularArrayRotation
{
    public void RunProgram()
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        int q = Convert.ToInt32(tokens_n[2]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = a_temp.Select(s => Convert.ToInt32(s)).ToArray();

        for (int i = 0; i < k; i++)
        {
            int last = a[n-1];
            Array.Copy(a, 0, a, 1, a.Length-1);
            a[0] = last;
        }

        for (int i = 0; i < q; i++)
        {
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a[m]);
        }
    }
}