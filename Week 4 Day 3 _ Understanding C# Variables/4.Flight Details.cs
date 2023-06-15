using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Flight name :");
        String s=Console.ReadLine();
        Console.WriteLine("Enter Ticket No :");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Flight Fare :");
        double ff=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Travelling Class :");
        char c=Console.ReadLine()[0];
        Console.WriteLine("Enter Source :");
        String s1=Console.ReadLine();
        Console.WriteLine("Enter Destination :");
        String g=Console.ReadLine();
        Console.WriteLine("Flight Details :");
        Console.WriteLine("Flight Name: "+s);
         Console.WriteLine("Ticket No: "+n);
          Console.WriteLine("Flight Fare: "+ff);
           Console.WriteLine("Class: "+c);
            Console.WriteLine("Source: "+s1);
             Console.WriteLine("Destination: "+g);

    }
}
