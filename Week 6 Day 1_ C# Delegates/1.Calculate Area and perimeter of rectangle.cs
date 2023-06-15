using System;

class Program
{
    public delegate void RectangleDelegate(double width,double height);
    //fill code here

    public static void PrintArea(double height, double width)
    {
        double area=height*width;
        Console.WriteLine("Area is: "+area);
        //fill code here
    }

    public static void PrintPerimeter(double height, double width)
    {
        double perimeter=2*(height+width);
        Console.WriteLine("Perimeter is: "+perimeter);
        //fill code here
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width");
        double width=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height=double.Parse(Console.ReadLine());

         RectangleDelegate rectangleDelegate = new RectangleDelegate(PrintArea);
        rectangleDelegate += PrintPerimeter;
        rectangleDelegate.Invoke(width, height);
        //fill code here
    }
}
