using Microsoft.EntityFrameworkCore;
using sl.BdConexion;
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
        private readonly ApplicationDbContext _context;

        public DBRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public BookingStatus GetStatus(string bookingId)
        {
            var lista = _context.Booking.ToList();
            var entidad =  lista.Where(x => x.Key == bookingId).FirstOrDefault();
            return entidad;
        }

        public void SaveBooking(BookingData bookingData)
        {
            throw new NotImplementedException();
        }
    }
}
