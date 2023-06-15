import java.util.*;

public class Main {
    public static void main(String args[]){
        
        Scanner sc=new Scanner(System.in);
     
        System.out.println("Enter the row size");
        int r=sc.nextInt();
        System.out.println("Enter the column size");
        int c=sc.nextInt();
        System.out.println("Enter the matrix values");
           int arr[][]=new int[r][c];
           System.out.println("The matrix is");
        for(int i=0;i<r;i++)
        {
            
            for(int j=0;j<c;j++)
            {
                arr[i][j]=sc.nextInt();
                
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
        for(int i=0;i<r;i++)
        {
            int rsum=0;
            for(int j=0;j<c;j++)
            {
                rsum=rsum+arr[i][j];
            }
                System.out.println("Row "+(i+1)+" sum is "+rsum);
            
    
        }
        
        for(int i=0;i<c;i++)
        {
            int csum=0;
            int j;
            for( j=0;j<r;j++)
            {
                csum=csum+arr[j][i];
            }
                System.out.println("Column "+(i+1)+" sum is "+csum);
            
            
        }

        

        //Fill your code here
    }
}

