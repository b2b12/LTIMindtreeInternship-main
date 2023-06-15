using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Contact
    {
        private string _name;
        private long _mobile;
        private long _altMobile;
        private string _address;
        private string _email;
        public Contact(string name,long mobile, long altMobile, string address, string email) 
        {
            this._name = name;
            this._mobile = mobile;
            this._altMobile = altMobile;
            this._address = address;
            this._email = email;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public long Mobile 
        {
            get { return this._mobile; }
            set { this._mobile = value; }
        }
        public long AltMobile
        {
            get { return this._altMobile; }
            set { this._altMobile = value; }
        }
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
    }
