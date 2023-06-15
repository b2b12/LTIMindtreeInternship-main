using System;

class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Enter branding expenses");
        double be=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter travel expenses");
        double te=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter food expenses");
        double fe=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter logistics expenses");
        double le=Convert.ToDouble(Console.ReadLine());
        double tt=be+te+fe+le;
        Console.WriteLine("Total expenses: Rs. {0:f2}",tt);
        Console.WriteLine("Branding expenses percentage:  {0:f2}%",(be/tt)*100);
        Console.WriteLine("Travel expenses percentage: {0:f2}%",(te/tt)*100);
        Console.WriteLine("Food expenses percentage: {0:f2}%",(fe/tt)*100);
        Console.WriteLine("Logistics expenses percentage: {0:f2}%",(le/tt)*100);





        //Fill your code here
    }
}
