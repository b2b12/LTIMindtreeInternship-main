using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter No of Contacts:");
        int n=int.Parse(Console.ReadLine());
        List<Contact> contacts=new List<Contact>();
        Console.WriteLine("Enter the Contact Details");
        for(int i=0;i<n;i++)
        {
            string[] details=Console.ReadLine().Split(',');
            string name=details[0];
            long mobile=long.Parse(details[1]);
            long altMobile=long.Parse(details[2]);
            string address=details[3];
            string email=details[4];

            Contact contact=new Contact(name,mobile,altMobile,address,email);
            contacts.Add(contact);
        }
        ContactBO contactsBo=new ContactBO();
        contactsBo.AddData(contacts);

        //fill your code
    }
}
