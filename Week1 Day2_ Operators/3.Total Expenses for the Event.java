import java.math.RoundingMode;
import java.text.DecimalFormat;
import java.util.*;
import java.io.*;

class Main{
	private static final DecimalFormat decfor=new DecimalFormat("0.00");
	public static void main(String[] args) throws Exception{ 
		double tot;
		double bp;
		double tp;
		double fp;
		double lp;
		Scanner sc=new Scanner(System.in);
		double be=sc.nextDouble();
		double te=sc.nextDouble();
		double fe=sc.nextDouble();
		double le=sc.nextDouble();
		
		System.out.println("Enter branding expenses");
		System.out.println("Enter travel expenses");
		System.out.println("Enter food expenses");
		System.out.println("Enter logistics expenses");
		tot=be+te+fe+le;
		System.out.println("Total expenses: Rs."+decfor.format(tot));
		bp=(be/tot)*100;
		tp=(te/tot)*100;
		fp=(fe/tot)*100;
		lp=(le/tot)*100;
		System.out.println("Branding expenses percentage: "+decfor.format(bp)+"%");
		
		System.out.println("Travel expenses percentage: "+decfor.format(tp)+"%");
		System.out.println("Food expenses percentage: "+decfor.format(fp)+"%");
		System.out.println("Logistics expenses percentage: "+decfor.format(lp)+"%");

//		Fill your code

	}
}
