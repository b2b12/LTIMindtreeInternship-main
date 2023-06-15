using System;
class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=n;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            //Fill your code here
        }
    }
