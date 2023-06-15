import java.util.*;
class Main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n=sc.nextInt();
        int i=1;
        int sum=0;
        while(i<n)
        {
            if(n%i==0)
            {
            sum=sum+i;
            }
            i++;
            
        }
        if(sum==n)
        {
            System.out.println("Perfect number");
        }
        else
        {
            System.out.println("Not a perfect number");
        }
        
            // Fill your code here
        
     }
}
