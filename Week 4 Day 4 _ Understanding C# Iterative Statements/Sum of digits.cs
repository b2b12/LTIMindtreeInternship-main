using System;

class Program {
    public static void Main(String[] args) {
        
        Console.WriteLine("Enter the value:");
        int n=Convert.ToInt32(Console.ReadLine());
        int s=0;
        int num=n;
        while(n>0)
        {
            
            int d=n%10;
            s+=d;
            n=n/10;
        }
        Console.WriteLine("Sum of digits in  "+num+" is "+s);
        }
        //Fill your code here
    }

