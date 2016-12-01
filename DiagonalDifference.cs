using System;
using System.Linq;

public class DiagonalDifference
{
    public void RunProgram()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = a_temp.Select(s => Convert.ToInt32(s)).ToArray();
        }

        var firstDiagonal = 0;
        var secondDiagonal = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(j == i)
                    firstDiagonal += a[i][j];
                if(j == n-1-i)
                    secondDiagonal += a[i][j];
            }
        }

        Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
    }
}