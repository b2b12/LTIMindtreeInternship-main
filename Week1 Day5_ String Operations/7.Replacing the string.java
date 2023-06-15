import java.util.*;
public class Main {
    public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the content of the document");
		String s=sc.nextLine();
		System.out.println("Enter the old name of the company");
		String g=sc.nextLine();
		System.out.println("Enter the new name of the company");
		String h=sc.nextLine();
		System.out.println("The content of the modified document is");
		System.out.println(s.replace(g,h));
		// fill your code here
	}
}
