using System;

class Address
{
    string _addressLine1;
    string _addressLine2;
    string _city;
    string _state;
    int _pincode;
    public Address() { }
    public Address(string _addressLine1, string _addressLine2, string _city, string _state, int _pincode)
    {
        this._addressLine1 = _addressLine1;
        this._addressLine2 = _addressLine2;
        this._city = _city;
        this._state = _state;
        this._pincode = _pincode;
    }
    public string AddressLine1
    {
        get { return this._addressLine1; }
        set { this._addressLine1 = value; }
    }
    public string AddressLine2
    {
        get { return this._addressLine2; }
        set { this._addressLine2 = value; }
    }
    public string City
    {
        get { return this._city; }
        set { this._city = value; }
    }
    public string State
    {
        get { return this._state; }
        set { this._state = value; }
    }
    public int Pincode
    {
        get { return this._pincode; }
        set { this._pincode = value; }
    }
}
