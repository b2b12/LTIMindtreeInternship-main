using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the userlist");
        int n=int.Parse(Console.ReadLine());
        HashSet<string> user=new HashSet<string>();
        for(int i=0;i<n;i++)
        {
            string userInput=Console.ReadLine();
            if(!string.IsNullOrEmpty(userInput))
            {
                user.Add(userInput);
            }
        }
        Console.WriteLine("Total number of unique users "+user.Count);

        //Fill Your Code Here 
    }
}
