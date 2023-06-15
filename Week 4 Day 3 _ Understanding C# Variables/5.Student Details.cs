using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name :");
        String s=Console.ReadLine();
        Console.WriteLine("Enter Roll No :");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Subject :");
        String g=Console.ReadLine();
        Console.WriteLine("Enter Marks :");
        double a=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Grade :");
        char c=Console.ReadLine()[0];
        Console.WriteLine(s+" Details :");
        Console.WriteLine("Roll No : "+n);
        Console.WriteLine("Subject : "+g);
        Console.WriteLine($"Marks : {a:F1}");
        Console.WriteLine("Grades : "+c);
    }
}
