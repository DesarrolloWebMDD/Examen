
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sL.Repositorio.Implementacion;
using sL.Repositorio.Interfaz;

namespace BookingGatewayService.RegisterIoC
{

    public class Register
    {
        public static void Services(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBookingGateway, BookingGateway>();
            services.AddScoped<IDBRepository, DBRepository>();
            

        }

        public static void DataBaseContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<SessionManager>();
        }

        public static void AddOptions(IServiceCollection services, IConfiguration configuration)
        {
        //    services.Configure<TokenOption>(option =>
        //    {
        //        configuration.GetSection("TokenOption")
        //        .Bind(option);
        //    });
        //    services.Configure<JwtOptions>(option =>
        //    {
        //        configuration.GetSection("jwt")
        //        .Bind(option);
        //    });
        }
    }

}
