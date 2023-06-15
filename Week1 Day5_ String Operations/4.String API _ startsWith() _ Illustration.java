import java.util.*;
public class Main {
	public static void main(String[] args) throws Exception {
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the string");
		String s=sc.nextLine();
		System.out.println("Enter the start string");
		String g=sc.nextLine();
		if(s.startsWith(g))
		{
			System.out.println("\""+s+"\""+"  starts with "+"\""+g+"\"");
		} 
		else
		{
			System.out.println("\""+s+"\""+" does not  start with "+"\""+g+"\"");
		}
		//Your code here
	}
}
