using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class Ticket
    {
        private string _movieName;
        //=======================
        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 3)
                {
                    _movieName = value;
                    return;
                }
                Console.WriteLine("MovieName : cannot be null or empty ");

            }
        }

        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        private int _price;
        //================
        public int Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price : must be greater than 0");
                    return;
                }
                _price = value;
            }
        }
        public int PriceAfterTax => ((14 * _price) / 100) + _price;
        private static int ticketCounter = 0;
        public int TicketId { get; set; }
        public Ticket()
        {
            TicketId = ticketCounter;
            ticketCounter++;
        }
        public static int GetTotalTicketsSold() => ticketCounter;
        public double ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
                return 0;
            return discountAmount;
        }
    }
}
