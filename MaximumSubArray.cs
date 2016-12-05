using System;
using System.Collections.Generic;
using System.Linq;

namespace playwithcode
{
    public class MaximumSubArray
    {
        public void RunProgram()
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                List<string> arr_temp = Console.ReadLine().Split(' ').ToList();
                int[] arr_n = arr_temp.Select(s => Convert.ToInt32(s)).ToArray();

                double totalResultOrder = arr_n.Max();
                double totalResultUnOrder = arr_n.Max();

                for (int k = 0; k < n-1; k++)
                {
                    double max = arr_n[k];
                    if (max > totalResultOrder)
                        totalResultOrder = max;
                    for (int j = k+1; j < n-1; j++)
                    {
                        max += arr_n[j];
                        if (max > totalResultOrder)
                            totalResultOrder = max;
                    }
                }

                arr_n = arr_n.OrderBy(o => o).ToArray();
                double maxB = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr_n[j] <= 0)
                        continue;
                    else
                    {
                        maxB += arr_n[j];
                        if (maxB > totalResultUnOrder)
                            totalResultUnOrder = maxB;
                    }
                }

                Console.WriteLine(String.Format("{0} {1}", totalResultOrder, totalResultUnOrder));
            }
        }
    }
}
