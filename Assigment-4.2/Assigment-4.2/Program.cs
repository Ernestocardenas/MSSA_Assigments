using System;

class Program
{
    public static void Main()
    {
        TwoDArray();
    }

    public static void TwoDArray()
    {
        int i, j;
        int[,] array = new int[3, 2];

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("The matix is: \n");
        for(i=0; i < 3; i++)
        {
            Console.Write("\n");
            for(j=0; j < 2; j++)
                Console.Write("|{0}",array[i,j]);
        }
        Console.Write("\n\n");
    }



}
