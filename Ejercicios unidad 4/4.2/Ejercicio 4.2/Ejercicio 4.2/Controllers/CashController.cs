using Ejercicio_4._2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ejercicio_4._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : ControllerBase
    {
        private static List<Moneda> Monedas = new List<Moneda>();

        [HttpGet("api/Consultar/")]
        public IActionResult Get()
        {
            return Ok(Monedas);
        }

        [HttpGet("api/ConsultarMoneda/")]
        public IActionResult GetMon(string nombre)
        {
            Moneda aux = new Moneda();
            foreach (Moneda m in Monedas)
            {
                if(m.Nombre == nombre)
                {
                    aux = m;
                }
            }
            if(aux.Nombre !=null)
                return Ok(aux);
            return BadRequest("Moneda no registrada");
        }

        [HttpPost]
        public IActionResult Post(Moneda dto)
        {
            if (dto == null)
                return BadRequest();
            Monedas.Add(dto);
            return Ok("Se registró correctamente la información presentada");
        }
    }
}
