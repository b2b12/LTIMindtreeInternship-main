using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delegates1
{
    class Program
    {
        delegate void EventDelegate(List<Event>events);
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter total number of events");
            int n=int.Parse(Console.ReadLine());
		// fill your code            
        List<Event> eventList=new List<Event>();

            Console.WriteLine("Enter event details");
            for(int i=0;i<n;i++)
            {
                string []input=Console.ReadLine().Split(',');
                string name=input[0];
                string type=input[1];
                string organizer=input[2];
                Event newEvent=new Event(name,type,organizer);
                eventList.Add(newEvent);
                
            }
            EventDelegate eventDelegate=events =>
            {
                Console.WriteLine("EventName    EventType   EventOrganizer");
                foreach(Event e in events)
                {
                    Console.WriteLine(e.ToString());
                }
            };
            eventDelegate(eventList);
     		// fill your code       
    }
    }
}

