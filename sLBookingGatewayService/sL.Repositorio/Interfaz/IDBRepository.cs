using sl.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL.Repositorio.Interfaz
{
    public interface IDBRepository
    {
        void SaveBooking(BookingData bookingData);
        BookingStatus GetStatus(string bookingId);
    }
}
