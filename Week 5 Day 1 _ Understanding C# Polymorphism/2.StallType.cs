using System;

class Stall
{
    public void ComputeCost(string stallType,int squareFeet)
    {
        if(stallType=="Gold")
        {
        Console.WriteLine("Gold costs Rs."+(squareFeet*100));
        }
    }
    public void ComputeCost(string stallType,int squareFeet,int numberOfTv)
    {
        if(stallType=="Diamond")
        {
        Console.WriteLine("Diamond costs Rs."+((squareFeet*150)+(numberOfTv*100)));
        }
    }
    public void ComputeCost(string stallType,int squareFeet,bool projectorAvailability)
    {
        if(stallType=="Platinum")
        {
          
        if(projectorAvailability)
        {
        Console.WriteLine("Platinum costs Rs."+((200*squareFeet)+1000));
        }
        else
        {
        Console.WriteLine("Platinum costs Rs."+(200*squareFeet));
        }
        
    }
    }
}
    //Fill your code here


