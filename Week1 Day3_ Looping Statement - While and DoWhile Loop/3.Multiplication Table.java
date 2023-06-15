import java.util.*;
class Main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter n");
        System.out.println("Enter m");
      
        int n=sc.nextInt();
        int m=sc.nextInt();
        System.out.println("The multiplication table of  "+n+"  is");
        int i=1;
        while(i<=m)
        {
            int table=n*i;
            System.out.println(i+"*"+n+"="+table);
            i++;
        }
            // Fill your code here
        
     }
}
