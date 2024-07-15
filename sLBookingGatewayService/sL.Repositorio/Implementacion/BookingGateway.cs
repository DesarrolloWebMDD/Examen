using sl.Entidades;
using sL.Repositorio.Interfaz;
using sL.Repositorio.Utilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL.Repositorio.Implementacion
{
    public class BookingGateway : IBookingGateway
    {
        private bool isBookingInProgress = false;
        private bool isReadOperationInProgress = false;
        private readonly IDBRepository repository;

        

        public void StartBooking()
        {
            lock (this)
            {
                if (isBookingInProgress)
                {
                    throw new BookingInProgressException();
                }

                isBookingInProgress = true;
            }
        }

        public void EndBooking()
        {
            lock (this)
            {
                isBookingInProgress = false;
            }
        }

        public BookingStatus GetBookingStatus(string bookingId)
        {
           
           BookingStatus status = new BookingStatus();
            lock (this)
            {
                if (isBookingInProgress)
                {
                    throw new BookingInProgressException();
                }
                status = repository.GetStatus(bookingId);
                isReadOperationInProgress = true;

                // Simular algún tipo de lógica para obtener el estado de la reserva
              // Supongamos que BookingStatus es una clase o struct que contiene el estado
                isReadOperationInProgress = false;

                return status;
            }
        }

        public void Booking(BookingData bookingData)
        {
            if (!isBookingInProgress)
            {
                throw new NoStartBookingException();
            }

            repository.SaveBooking(bookingData); // Guardar datos de la reserva en el repositorio
        }
    }
}
