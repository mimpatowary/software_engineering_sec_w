using System;

class Program
{
    static void Main()
    {
        int[][] jarray = new int[3][];
        jarray[0] = new int[] { 10, 12 };
        jarray[1] = new int[] { 1, 2, 3, 4 };
        jarray[2] = new int[] { 3, 4, 5 };

        foreach (int[] subArray in jarray)
        {
            foreach (int b in subArray)
            {
                Console.Write(b + " ");
            }
        }

        Console.WriteLine(); // Move to next line after printing all elements
    }
}