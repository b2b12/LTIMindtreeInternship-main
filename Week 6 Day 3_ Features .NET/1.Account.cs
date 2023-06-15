using System;
using System.Collections.Generic;

class Account
{
    private string aNumber;
    private double premium;
    private int discountPercent;
    public Account(string aNumber,double premium,int discountPercent)
    {
        this.aNumber=aNumber;
        this.premium=premium;
        this.discountPercent=discountPercent;
    }
    
    public string ANumber{
        get{return aNumber;}
        set{aNumber=value;}
    }
    public double Premium{
        get{return premium; }
        set{premium=value;}
    }
    public int DiscountPercent{
        get{return discountPercent;}
        set{discountPercent=value;}
    }
    public Func<double,int,double>ActualPrice=(prem,discPerc)=>prem-(prem*discPerc/100.0);
    public override string ToString()
        {
            double actualPrice=ActualPrice(premium,discountPercent);
            return ($"Account :{aNumber}\nPremium :Rs.{premium:F1}\nDiscount :{discountPercent}%\nAmount to be paid :Rs.{actualPrice:F1}");

        }
    

}
