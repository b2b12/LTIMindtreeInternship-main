using System;
public class Program
{
    public static void Main(string[] args)
    {
        TicketBooking tb = new TicketBooking();
        Console.WriteLine("Enter the mode of Payment:\n1.Cash Payment\n2.Wallet Payment\n3.Credit Card");

        int modee = Convert.ToInt32(Console.ReadLine());
 
        switch (modee)
        {
            case 1:
                Console.WriteLine("Enter the Amount of Payment:");
                double cashPayment=double.Parse(Console.ReadLine());
                tb.MakePayment(cashPayment);
                //Fill your code here
                break;
            case 2:
                Console.WriteLine("Enter the Wallet Number:");
                string walletno=Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                double walletPayment=double.Parse(Console.ReadLine());
                tb.MakePayment(walletno,walletPayment);
                //Fill your code here
                break;
            case 3:
                Console.WriteLine("Enter the Credit Card Number:");
                string creditNumber=Console.ReadLine();
                Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
                string cv=Console.ReadLine();
                Console.WriteLine("Enter the Card Holder Name:");
                string cname=Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                double creditPayment=double.Parse(Console.ReadLine());
                tb.MakePayment(creditNumber,cv,cname,creditPayment);
                //Fill your code here
                break;

            case 4:
                Console.WriteLine("Please select the correct mode of payment...");
                break;
        }
    }
}
