using System;

class Program {
    public static void Main(String[] args) {
        int n=Convert.ToInt32(Console.ReadLine());
        int fact=1;
        for(int i=1;i<=n;i++)
        {
            fact=fact*i;
        }
        Console.WriteLine(fact);
        //Fill your code here
    }
}
