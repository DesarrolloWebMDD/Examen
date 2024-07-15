using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL.Repositorio.Utilidad
{
   

    public class BookingInProgressException : Exception
    {
        public BookingInProgressException() : base("Booking is already in progress.")
        {
        }
    }

    public class ReadOperationInProgressException : Exception
    {
        public ReadOperationInProgressException() : base("Read operation is already in progress.")
        {
        }
    }
    public class NoStartBookingException : Exception
    {
        public NoStartBookingException() : base("StartBooking must be called before making a booking.")
        {
        }
    }
}
