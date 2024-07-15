using sl.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL.Repositorio.Interfaz
{
    public interface IBookingGateway
    {
        void StartBooking();
        void EndBooking();
        //BookingStatus GetBookingStatus();
        BookingStatus GetBookingStatus(string bookingId);

        void Booking(BookingData bookingData);
    }
}
