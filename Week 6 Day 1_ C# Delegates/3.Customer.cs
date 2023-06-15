using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer(string _firstName, string _lastName)
    {
        this._firstName = _firstName;
        this._lastName = _lastName;
    }

    public void DisplayFirstName()
    {
        Console.WriteLine("First Name: "+_firstName);
        //fill code here
    }

    public void DisplayLastName()
    {
        Console.WriteLine("Last Name: "+_lastName);
        //fill code here
    }
}
