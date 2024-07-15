using sl.Entidades;
using sL.Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL.Repositorio.Implementacion
{
    public class DBRepository : IDBRepository
    {
        public BookingStatus GetStatus(string bookingId)
        {
            throw new NotImplementedException();
        }

        public void SaveBooking(BookingData bookingData)
        {
            throw new NotImplementedException();
        }
    }
}
