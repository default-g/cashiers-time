// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using Avalonia.OpenGL;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int theTime = 0;
        while (customers.Length > 0)
        {
            int busyCashiers = n > customers.Length ? customers.Length : n;
            for (int i = 0; i < busyCashiers; i++)
            {
                customers[i]--;
            }
            customers = Array.FindAll(customers, x => x != 0);

            theTime++;
        }
        return theTime;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(HW1.QueueTime( new int [] {5, 3, 4 }, 1) == 12);
        Console.WriteLine(HW1.QueueTime( new int [] {10, 2, 3, 3}, 2) == 10);
        Console.WriteLine(HW1.QueueTime( new int [] {2, 3, 10 }, 2) == 12);


}
}