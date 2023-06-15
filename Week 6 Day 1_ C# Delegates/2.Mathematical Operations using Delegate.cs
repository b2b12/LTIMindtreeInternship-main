using System;
public delegate void CalculateDelegate(int num1,int num2);
//fill code here
class Program
{
    public static void Addition(int num1, int num2) {
        int add=num1+num2;
        Console.WriteLine("the sum is : "+add);
        //fill code here
    }

    public static void Subtract(int num1, int num2)
    {
        int sub=num1-num2;
        Console.WriteLine("The subtraction is : "+sub);
	    //fill code here
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the num1");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the num 2");
        int num2=int.Parse(Console.ReadLine());
        CalculateDelegate obj=new CalculateDelegate(Addition);
        obj+=Subtract;
        obj.Invoke(num1,num2);

	    //fill code here
    }
}
