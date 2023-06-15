using System;

class Program
{
    public delegate void NameDelegate();

    //fill code here
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first name:");
        string _firstName=Console.ReadLine();
        Console.WriteLine("Enter the last name:");
        string _lastName=Console.ReadLine();
        Customer customer=new Customer(_firstName,_lastName);
        Console.WriteLine("Customer Details");

        NameDelegate obj=customer.DisplayFirstName;
        obj+=customer.DisplayLastName;
        obj.Invoke();

        

        

        //fill code here
    }
}
