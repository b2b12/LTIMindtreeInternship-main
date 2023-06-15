using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the booking details");
        string seatAvailability=Console.ReadLine();
        SeatBooking obj=new SeatBooking(seatAvailability);
        Console.WriteLine("Enter the seat number to book");
        int seatNumber=int.Parse(Console.ReadLine());
        try
        {
            obj.BookSeat(seatNumber);
        }
        catch(SeatNotAvailableException e)
        {
            Console.WriteLine(e.Message);
        }

        //fill code here
    }
}
