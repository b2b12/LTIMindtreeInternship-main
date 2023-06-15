import java.util.*;
class Main {
    public static void main(String[] args) {
        int c;
        int a=0;
        int b=1;
        int i;
        Scanner sc=new Scanner(System.in);
        int n=sc.nextInt();
        System.out.println("Enter the range:");
        System.out.println("Fibonacci series:");
        System.out.println(a);
        System.out.println(b);
        for(i=2;i<n;i++)
        {
            c=a+b;
            System.out.println(c);
            a=b;
            b=c;
        }

            // Fill your code here
        
     }
}
