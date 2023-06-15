using System;

class Program {
    public static void Main(String[] args) {
          int n=Convert.ToInt32(Console.ReadLine());
        int count=0;
        for(int i=1;i<=n;i++)
        {
            if(n%i==0)
            {
                count++;
            }
        }
                if(count==2)
                {
                    Console.WriteLine("Prime");
                }
                else 
                {
                    Console.WriteLine("Not prime");
                }
            }
        //Fill your code here
    }


    
