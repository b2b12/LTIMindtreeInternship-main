using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
        Console.WriteLine("Enter the item type name");
        string name=Console.ReadLine();
        //fill code here
        Console.WriteLine("Enter the deposit");
        int deposit=int.Parse(Console.ReadLine());
        //fill code here
        Console.WriteLine("Enter the cost per day");
        int cost=int.Parse(Console.ReadLine());

        //fill code here
        Console.WriteLine("Item type details");
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Deposit:"+deposit);
        Console.WriteLine("CostPerDay:"+cost);
        }
        catch(Exception e)
        {
            Console.WriteLine("Input string was not in the correct format");
        }
        //fill code here
    }
}
