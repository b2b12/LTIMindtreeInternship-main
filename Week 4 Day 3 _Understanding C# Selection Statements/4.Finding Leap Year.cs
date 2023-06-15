using System;

class Program {
    public static void Main(String[] args) {
        int y=Convert.ToInt32(Console.ReadLine());
        if(y%400==0||y%4==0&&y%100!=0)
        {
            Console.WriteLine(y+" is a leap year");
        }
        else
        {
            Console.WriteLine(y+" is not a leap year");
        }
        //Fill your code here
    }
}
