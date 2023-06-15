using System;
public class InvalidDateException : Exception {
    public  InvalidDateException(string message):base(message)
    {}
}
public class Program
{
    public static void Main(){
        Console.WriteLine("Enter the start date(dd/MM/yyyy hh:mm:ss tt):");
        string start = Console.ReadLine();
        Console.WriteLine("Enter the end date(dd/MM/yyyy hh:mm:ss tt):");
        string end = Console.ReadLine();
        try
        {
        DateTime startDate=DateTime.ParseExact(start,"dd/MM/yyyy hh:mm:ss tt",null);
        DateTime endDate=DateTime.ParseExact(end,"dd/MM/yyyy hh:mm:ss tt",null);

       Console.WriteLine("Starting Date: " + startDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
            Console.WriteLine("Ending Date: " + endDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid Date Format...");
        }
        catch(InvalidDateException e)
        {
            Console.WriteLine(e.Message);
        }
        //fill your code
    }
}
