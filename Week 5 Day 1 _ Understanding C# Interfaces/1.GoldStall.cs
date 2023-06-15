using System;

class GoldStall :IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Details
    {
        get { return this._details; }
        set { this._details = value; }
    }

    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }

    public string OwnerName
    {
        get { return this._ownerName; }
        set { this._ownerName = value; }
    }

    public GoldStall()
    {
    }

    public GoldStall(string _name, string _details, double _cost, string _ownerName)
    {
        this._name = _name;
        this._details = _details;
        this._cost = _cost;
        this._ownerName = _ownerName;
    }
    public void display()
    {
        Console.WriteLine("Stall name:"+_name);
        Console.WriteLine("Details:"+_details);
        Console.WriteLine("Cost:"+_cost.ToString("0.00"));
        Console.WriteLine("Owner:"+_ownerName);
    }

    //fill code here
}
