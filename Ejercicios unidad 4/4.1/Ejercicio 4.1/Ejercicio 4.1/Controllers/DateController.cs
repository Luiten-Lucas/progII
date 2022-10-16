using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace Ejercicio_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);
            string dianro = DateTime.Now.Day.ToString();
            string dia = DateTime.Now.DayOfWeek.ToString();
            string anio = DateTime.Now.Year.ToString();

            switch (dia)
            {

                case "Monday":
                    dia = "Lunes";
                    break;
                case "Tuesday":
                    dia = "Martes";
                    break;
                case "Wednesday":
                    dia = "Miércoles";
                    break;
                case "Thursday":
                    dia = "Jueves";
                    break;
                case "Friday":
                    dia = "Viernes";
                    break;
                case "Saturday":
                    dia = "Sábado"; ;
                    break;
                case "Sunday":
                    dia = "Domingo";
                    break;
            }

            return Ok("El día de hoy es: "+ dianro+" ," + dia + ", del mes de: "+ monthName + "  año:"+ anio);
            
        }
    }
}
