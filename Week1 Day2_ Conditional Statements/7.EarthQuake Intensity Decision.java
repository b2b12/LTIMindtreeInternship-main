import java.util.*;
import java.io.*;
import java.text.*;

public class Main{
    public static void main(String args[]) throws IOException{
        
       Scanner sc=new Scanner(System.in);
       System.out.println("Richter Magnitude:");
         float m=sc.nextFloat();
        if(m<=2.4)
        {
            System.out.println("Micro");
        }
        else if(m>=2.5&&m<=5.4)
        {
            System.out.println("Light");
        }
        else if(m>=5.5&&m<=6.0)
        {
            System.out.println("Moderate");
        }
        else if(m>=6.1&&m<=6.9)
        {
            System.out.println("Strong");
        }
        else if(m>=7.0&&m<=7.9)
        {
            System.out.println("Major");
        }
        else if(m>=8.0)
        {
            System.out.println("Great");
        }
        // fill the code
    }
}
