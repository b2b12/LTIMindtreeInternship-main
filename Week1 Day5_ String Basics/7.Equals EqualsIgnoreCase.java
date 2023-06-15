import java.util.*;
public class Main {
	public static void main(String []args){
		Scanner sc=new Scanner (System.in);
		System.out.println("Address 1:");
		System.out.println("Address 2:");
		String a1=sc.nextLine();
		String a2=sc.nextLine();
		if(a1.equals(a2))
		{
			System.out.println("RED");
		}
		else if(a1.trim().equals(a2))
		{
			System.out.println("YELLOW");
		}
		else if(a1.equalsIgnoreCase(a2))
		{
			System.out.println("BLUE");
		}
		else 
		{
			System.out.println("GREEN");
		}
		//fill your code here
	}
}
