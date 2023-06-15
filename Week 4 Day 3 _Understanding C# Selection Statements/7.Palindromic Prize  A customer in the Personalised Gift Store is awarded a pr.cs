using System;
class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int rev=0;
            int num=n;
            while(n>0)
            {
                int d=n%10;
                rev=rev*10+d;
                n=n/10;
            }
            
            if(rev==num&&num>99)
            {
                Console.WriteLine("yes");
            }
            
            else
            Console.WriteLine("no");

            //Fill your code here
        }
    }
