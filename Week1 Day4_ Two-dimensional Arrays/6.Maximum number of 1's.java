import java.util.*;

public class Main {
    public static void main(String args[]){
        Scanner sc=new Scanner(System.in);
        int m=sc.nextInt();
        int n=sc.nextInt();
        int a[][]=new int[m][n];
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                a[i][j]=sc.nextInt();
            }
        }
        int maxonecount=0;
        int maxonerow=0;
        for(int i=0;i<m;i++)
        {
             int onescount=0;
            for(int j=0;j<n;j++)
            {
                if(a[i][j]==1)
                {
                    onescount++;
                }

            }
        
        if(onescount>maxonecount)
        {
            maxonerow=i;
            maxonecount=onescount;

        }
        }
        System.out.println(maxonerow);
        //Fill your code here
    }
}

