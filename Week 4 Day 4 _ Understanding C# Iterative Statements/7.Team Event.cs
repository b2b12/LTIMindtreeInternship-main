using System;

class Program
{
    static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
       if(n<10)
       {
           Console.WriteLine("Invalid Input");
       }
       else
       {
       int ld=n%10;
       int fd=n;
       while(fd>=10)
       {
           fd/=10;
       }
       int diff=Math.Abs(fd-ld);
       Console.WriteLine(diff);
       }
        }
    }
