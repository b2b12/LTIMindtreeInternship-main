import java.util.*;
public class Main {
    public static void main(String[] args) {
		String a="";
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter a string to reverse");
		String s=sc.nextLine();

		for(int i=s.length()-1;i>=0;i--)
		{
			a=a+s.charAt(i);

		}
		System.out.println("Reverse of the string is "+a);

		// fill your code here
	}
}
