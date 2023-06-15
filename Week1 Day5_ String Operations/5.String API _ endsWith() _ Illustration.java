import java.util.*;
public class Main {
	public static void main(String[] args) throws Exception {
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the string");
		String s=sc.nextLine();
		System.out.println("Enter the end string");
		String g=sc.nextLine();
		if(s.endsWith(g))
		{
			System.out.println("\""+s+"\""+"  ends with "+"\""+g+"\"");
		} 
		else
		{
			System.out.println("\""+s+"\""+" does not  end with "+"\""+g+"\"");
		}
		//Your code here
	}
}
