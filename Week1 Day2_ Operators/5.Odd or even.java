import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args){    	     
           //Fill your code
           Scanner sc=new Scanner (System.in);
           int n1;
           System.out.println("Enter any number :");
           n1=sc.nextInt();
           if((n1&1)!=1)
           {
               System.out.println(n1+" is even.");
           }
           else{
               System.out.println(n1+" is odd.");
           }
    }
}
