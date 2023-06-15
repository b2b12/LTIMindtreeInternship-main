using System;

class Program {
    public static void Main(String[] args) {
        int n=Convert.ToInt32(Console.ReadLine());
        if(n%7==0&&n%3==0)
        {
            Console.WriteLine(n+" is divisible by both 7 and 3");
        }
        else
        {
            Console.WriteLine(n+" is not divisible by both 7 and 3");
        }
        //Fill your code here
    }
}
