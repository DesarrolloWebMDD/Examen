using sL.Repositorio.Implementacion;
using sL.Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sl.Aplicacion
{
    public class BookingGatewayFactory
    {
        public IBookingGateway CreateBookingGateway()
        {
            return new BookingGateway();
        }

        [Obsolete("Please use CreateObject instead.")]
        public IBookingGateway CreateObject()
        {
            return new BookingGateway(); // Cambia DBRepository por la implementación real
        }

        [Obsolete("NewObject method is deprecated.", true)]
        public IBookingGateway NewObject()
        {
            throw new NotSupportedException("NewObject method is deprecated.");
        }

        
    }
}
