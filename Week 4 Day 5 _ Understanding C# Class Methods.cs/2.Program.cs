using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter the item type name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        double costPerDay=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the deposit");
        double deposit=double.Parse(Console.ReadLine());

        ItemType obj=new ItemType();
        obj.Name=name;
        obj.CostPerDay=costPerDay;
        obj.Deposit=deposit;

        obj.Display();
        Console.ReadLine();


        
        //fill code here
    }
}
