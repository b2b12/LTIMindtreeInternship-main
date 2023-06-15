using System;

class Program {
    public static void Main(String[] args) {
        int a=Convert.ToInt32(Console.ReadLine());
         int b=Convert.ToInt32(Console.ReadLine());
          int c=Convert.ToInt32(Console.ReadLine());
          if(a>b&&a>c)
          {
              Console.WriteLine(a+" is the maximum number");
          }
          else if(b>a&&b>c)
          {
              Console.WriteLine(b+" is the maximum number");
          }
          else
          {
          Console.WriteLine(c+" is the maximum number");
          }
        //Fill your code here
    }
}
