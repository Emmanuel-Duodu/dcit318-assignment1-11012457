using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        double ticketPrice;

        if (age >= 65 || age <= 12)
        {
            ticketPrice = 7.00;
        }
        else
        {
            ticketPrice = 10.00;
        }

        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
    }
}