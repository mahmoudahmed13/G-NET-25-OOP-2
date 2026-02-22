using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class Cinema
    {
        List<Ticket> _list = new List<Ticket>(20);
        public Ticket this[int index]
        {
            get 
            {
                if (index >= 0 && index < _list.Count())
                    return _list[index];
                return null;
                
            
            }
            set 
            {
                if (index >= 0 && index < _list.Count())
                    _list[index] = value;
                return;
            }
    
        }
        //b.Allow User To Get Movie By movieName
        public Ticket? this[string movie]
        {
            get
            {
                foreach (var ticket in _list)
                {
                    if (ticket.MovieName == movie)
                        return ticket;
                }
                return null;
            }
        }
        public bool AddTicket(Ticket t)
        {
            if (t != null)
            {
                _list.Add(t);
                return true;
            }
            return false;
        }
    }
}
