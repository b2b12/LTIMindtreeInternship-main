using System;
using System.Collections.Generic;
using System.Text;

class Event
{
    private string _eventName;
    private string _organiserName;
    private double _eventCost;

    public Event(string eventName, string organiserName, double eventCost)
    {
        EventName = eventName;
        OrganiserName = organiserName;
        EventCost = eventCost;
    }

    public Event()
    {
    }

    public string EventName { get => _eventName; set => _eventName = value; }
    public string OrganiserName { get => _organiserName; set => _organiserName = value; }
    public double EventCost { get => _eventCost; set => _eventCost = value; }

    public override string ToString() {
        //fill code here
        return $"{_eventName}|{_organiserName}|{_eventCost}";
    }

    public void Display(List<Event> eventList) {
        Console.WriteLine("List of events");
        eventList.ForEach(e=>Console.WriteLine(e.ToString()));
        //fill code here
    }
}
