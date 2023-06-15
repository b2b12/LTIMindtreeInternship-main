using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stall Type:");
        Console.WriteLine("1.Gold Stall\n2.Executive Stall\n3.Premium Stall");
        int choice = Convert.ToInt32(Console.ReadLine());
		IStall stall;
		switch(choice)
		{
			case 1:
			Console.WriteLine("Enter the stall name");
			string goldName=Console.ReadLine();
			Console.WriteLine("Enter the details");
			string goldDetails=Console.ReadLine();
			Console.WriteLine("Enter the cost");
			double goldCost=double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
			string goldOwnerName=Console.ReadLine();
			stall=new GoldStall(goldName,goldDetails,goldCost,goldOwnerName);
			stall.display();
			break;
			//Fill your code here
		
		case 2:
		
			Console.WriteLine("Enter the stall name");
			string executiveName=Console.ReadLine();
			Console.WriteLine("Enter the details");
			string executiveDetails=Console.ReadLine();
			Console.WriteLine("Enter the cost");
			double executiveCost=double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
			string executiveOwnerName=Console.ReadLine();
			Console.WriteLine("Enter the number of TV set");
			int executiveNumberOfTVSet=int.Parse(Console.ReadLine());
			stall=new ExecutiveStall(executiveName,executiveDetails,executiveCost,executiveOwnerName,executiveNumberOfTVSet);
			stall.display();
			break;
			//Fill your code here
		
		case 3:
		
			Console.WriteLine("Enter the stall name");
			string premiumName=Console.ReadLine();
			Console.WriteLine("Enter the details");
			string premiumDetails=Console.ReadLine();
			Console.WriteLine("Enter the cost");
			double premiumCost=double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
			string premiumOwnerName=Console.ReadLine();
			Console.WriteLine("Enter the number of projector");
			int premiumNumberOfProjector=int.Parse(Console.ReadLine());
			stall=new PremiumStall(premiumName,premiumDetails,premiumCost,premiumOwnerName,premiumNumberOfProjector);
			stall.display();
			break;
			//Fill your code here
		
	    default:
		
			Console.WriteLine("Invalid Input");
			break;
			//Fill your code here
		}

    }
}
