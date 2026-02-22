using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class BookingHelper
    {
        private static int counter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets > 5)
                return (pricePerTicket * numberOfTickets) - ((pricePerTicket * numberOfTickets) * 0.10);
            return pricePerTicket * numberOfTickets;

        }

        // Method to generate unique booking reference
        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}";
        }
    }
}
