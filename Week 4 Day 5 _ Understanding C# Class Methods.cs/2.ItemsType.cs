using System;
public class ItemType{
    private string _name;
    private double _costPerDay;
    private double _deposit;

    public string Name{
        get{return _name;}
        set{_name=value;}
    }
    public double CostPerDay{
        get{return _costPerDay;}
        set{_costPerDay=value;}
    }
    public double Deposit{
        get{return _deposit;}
        set{_deposit=value;}
    }

    //fill code here

    public void Display() {
        Console.WriteLine("Item type details");
        Console.WriteLine("Name:"+Name);
        Console.WriteLine("CostPerDay:{0:f2}",CostPerDay);
        Console.WriteLine("Deposit:{0:f2}",Deposit);
        //fill code here
    }
}
