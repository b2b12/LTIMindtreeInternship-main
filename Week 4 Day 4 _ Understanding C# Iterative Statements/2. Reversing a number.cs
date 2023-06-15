using System;

class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Enter the number :");
        int n=Convert.ToInt32(Console.ReadLine());
        int rev=0;
        while(n>0)
        {
            int d=n%10;
            rev=rev*10+d;
            n=n/10;
        }
        Console.WriteLine("Reverse of the number is "+rev);
    }
}
