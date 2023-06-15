import java.util.*;
class Main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        String s1=sc.nextLine();
        String s2=sc.nextLine();
        int l1=s1.length();
        int l2=s2.length();
        System.out.println("The length of the first string is "+l1);
        System.out.println("The length of the second string is "+l2);
        System.out.println("The uppercase of the first string is "+s1.toUpperCase());
        System.out.println("The uppercase of the second string is "+s2.toUpperCase());
        System.out.println("The concatenated string is "+s1.concat(s2));
        int a=s1.compareTo(s2);
        if(a==0)
        {
            System.out.println("Both the input strings are the same");
        }
        else if(a<0)
        {
            System.out.println(s1+" appears before "+s2);
        }
        else
        {
            System.out.println(s2+" appears before "+s1);
        }

        

        
            // Fill your code here
        
     }
}
