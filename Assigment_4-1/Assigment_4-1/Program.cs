class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Assigmenmt 4.1");
        Console.WriteLine("-----------------------------------");
        ReturnEvenNumbersTask();
        Console.WriteLine("-----------------------------------");
        YearisLeap();
        Console.WriteLine("-----------------------------------");
        ReverseString();
        Console.WriteLine("-----------------------------------");
        SpaceCount();

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

    static void ReverseString()
    {
        

        string originalString = ("Dudewheremychar");
        Console.WriteLine(originalString);
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------\n");

        string reversedString = string.Empty;

        for (int i = originalString.Length -1; i >= 0; i--)
        {
            reversedString += originalString[i];
        }

        Console.WriteLine(reversedString);
               
        }
     static void SpaceCount()
    {

        string userInput;

        Console.WriteLine("PLease enter a string: ");
        userInput = Console.ReadLine();
        Console.WriteLine("YOur string is: " + userInput);

        int space = 0;

        for (int i = 0; i < userInput.Length; i++)
        {
            if (userInput[i] == ' ')
                space++;
        }
        Console.WriteLine("Spaces: " + space);

    }



}
