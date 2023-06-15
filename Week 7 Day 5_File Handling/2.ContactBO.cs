using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class ContactBO
{
    public void AddData(List<Contact> list) 
    {
        List<Contact> uniqueContact=new List<Contact>();
        foreach(Contact contact in list)
        {
            if(!uniqueContact.Contains(contact))
            {
                uniqueContact.Add(contact);
            }
        }
        //fill your code
        using (StreamWriter sw = new StreamWriter("output.txt")) 
        {
            foreach(Contact contact in uniqueContact)
            {
                sw.WriteLine($"{contact.Name},{contact.Mobile},{contact.AltMobile},{contact.Address},{contact.Email}");
            }
  	    //fill your code
            sw.Close();
	    //fill your code
        }
        Console.WriteLine("Contact Details Added");
    }
}
