using System;

class Program
{
    static void Main(string[ ]args)
    {
        int points;
        Console.WriteLine("Enter number of lost team's coins left on board");
        int n=Convert.ToInt32(Console.ReadLine());
        
        if(n<=0||n>9)
        {
            Console.WriteLine("Invalid Input");
        }
        else{
        Console.WriteLine("Has winning team pocketed red[y or n]?");
        char c=Console.ReadLine()[0];
        if(c=='y')
        {
            points=n+5;
            Console.WriteLine("Points won: "+points);

        }
        else
        {
            points=n;
            Console.WriteLine("Points won: "+points);
        }
    }
    }
    

}
