using System;

public class Program {
	public static void Main(string[] args)
	{
		 Console.WriteLine("Enter the customer details");
		  Console.WriteLine("Enter the id :");
		  int id=int.Parse(Console.ReadLine());
		   Console.WriteLine("Enter the name :");
		   string name=Console.ReadLine();
		    Console.WriteLine("Enter the email :");
			string email=Console.ReadLine();
			 Console.WriteLine("Enter the address :");
			 string address=Console.ReadLine();
			  Console.WriteLine("Enter the purpose :");
			  string purpose=Console.ReadLine();
			   Console.WriteLine("Enter the other customer details :");
			   string otherDetails=Console.ReadLine();

			   Customer obj=new Customer();
			   obj.Id=id;
			   obj.Name=name;
			   obj.Email=email;
			   obj.Address=address;
			   obj.Purpose=purpose;
			   obj.OtherDetails=otherDetails;

			   obj.Display();
			   Console.ReadLine();

		//Fill your code
	}
}
