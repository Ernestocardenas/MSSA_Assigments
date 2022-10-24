class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Assigmenmt 4.1");
        Console.WriteLine("-----------------------------------");
        ReturnEvenNumbersTask();
        Console.WriteLine("-----------------------------------");
    }

    static void ReturnEvenNumbersTask()
    {

        string str = string.Empty;
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                str += i + " ";
            }
        }

        Console.WriteLine(str);

    }

    static void YearisLeap()
    {
        int leap_year;
        Console.Write("\n\n");
        Console.Write("Check whether a given year is leap year or not:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an year : ");
        leap_year = Convert.ToInt32(Console.ReadLine());

        if ((leap_year % 400) == 0)
            Console.WriteLine("{0} is a leap year.\n", leap_year);
        else if ((leap_year % 100) == 0)
            Console.WriteLine("{0} is not a leap year.\n", leap_year);
        else if ((leap_year % 4) == 0)
            Console.WriteLine("{0} is a leap year.\n", leap_year);
        else
            Console.WriteLine("{0} is not a leap year.\n", leap_year);
    }
}
