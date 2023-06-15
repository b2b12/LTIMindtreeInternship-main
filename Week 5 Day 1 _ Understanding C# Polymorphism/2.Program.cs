using System;

class Program
{
    static void Main(string[] args)
    {
        Stall obj=new Stall();
        Console.WriteLine("Enter the stall type");
        string stallType=Console.ReadLine();
        Console.WriteLine("Enter the square feet");
        int squareFeet=int.Parse(Console.ReadLine());
        
        if(stallType=="Gold")
        {
            obj.ComputeCost(stallType,squareFeet);
        }
        else if(stallType=="Diamond")
        {
            Console.WriteLine("Enter the number of TV");
            int numberOfTV=int.Parse(Console.ReadLine());
            obj.ComputeCost(stallType,squareFeet,numberOfTV);
        }
        else if(stallType=="Platinum")
        {
            Console.WriteLine("Do you need a projector(yes/no)");
            string input=Console.ReadLine();
            bool projectorAvailability=input.ToLower()=="yes";
            obj.ComputeCost(stallType,squareFeet,projectorAvailability);

        }
        else
        {
            Console.WriteLine("Invalid stall type");
        }
        //fill code here
    }
}
