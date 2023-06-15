import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args){    	     
           //Fill your code
           Scanner sc=new Scanner(System.in);
           System.out.println("Enter the two numbers ");
           int n1=sc.nextInt();
           int n2=sc.nextInt();
           System.out.println("The two values after swapping are");
           n1=n1^n2;
           n2=n1^n2;
           n1=n1^n2;
           System.out.println(n1);
           System.out.println(n2);
    }
}
