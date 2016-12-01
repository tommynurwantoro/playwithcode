using System;
using System.Linq;

public class StairCase
{
    public void RunProgram()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(j > n - 2 - i)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}