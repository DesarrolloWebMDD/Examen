using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using sl.Aplicacion;
using sL.Repositorio.Interfaz;
using sL.Repositorio.Utilidad;
using sl.Entidades;
using System.Threading.Tasks;

namespace BookingGatewayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingRequestController : ControllerBase
    {
       

       

        [HttpGet("getbookingstatus")]
        public async Task<ActionResult> GetBookingStatus(string bookingId)
        {
            BookingStatus result = null;
            BookingGatewayFactory factory = new BookingGatewayFactory();
            try
            {
              
                IBookingGateway bookingGateway = factory.CreateBookingGateway();

                try
                {
                    bookingGateway.StartBooking();
                    // Aqui se puede hacer otras operaciones o procesos 
                    bookingGateway.EndBooking();

                    var bookingStatus = bookingGateway.GetBookingStatus(bookingId);
                    result = bookingStatus;


                    Console.WriteLine($"Booking status: {bookingStatus}");
                }
                catch (BookingInProgressException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ReadOperationInProgressException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("savebooking")]
        public async Task<IActionResult> SaveBooking([FromBody] BookingData bookingData)
        {
            BookingStatus result = null;
            BookingGatewayFactory factory = new BookingGatewayFactory();
            try
            {

                IBookingGateway bookingGateway = factory.CreateBookingGateway();

                try
                {
                    bookingGateway.StartBooking();
                    // Aqui se puede hacer otras operaciones o procesos 
                    bookingGateway.EndBooking();
                    bookingGateway.Booking(bookingData);

                }
                catch (BookingInProgressException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ReadOperationInProgressException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(result);
            }
            return Ok("Ok");
        }
    }
}
