using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the count");
         int c=Convert.ToInt32(Console.ReadLine());
        if(c<=0)
        {
            Console.WriteLine("Invalid Input");
        }
       else
       {
        Console.WriteLine("Enter numbers");
        double num;
        double sum=0;
        double avg;
        
        for(int i=0;i<c;i++)
        {
            num=double.Parse(Console.ReadLine());
            sum=sum+num;
            
        }
        avg=sum/c;
        Console.Write("Sum of numbers is {0:f1} ",sum);
        Console.WriteLine(" average of numbers is {0:f1} ",avg);
    }
    }
}
