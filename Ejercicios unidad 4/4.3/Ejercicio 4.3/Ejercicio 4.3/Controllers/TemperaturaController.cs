using Ejercicio_4._3.Datos;
using Ejercicio_4._3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ejercicio_4._3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        private static RegistroTemp registros = RegistroTemp.ObtenerInstancia();
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(registros.ObtenerTemperaturas());
        }

        [HttpPost]
        public IActionResult Post(Temperatura dto)
        {
            if (dto.Iot == 0)
                return BadRequest("Registro inválido.");

            return Ok(registros.RegistrarTemperatura(dto));
        }
        
        [HttpGet("/RegistrosPorIot")]
        public IActionResult GetPorIot(int iot)
        {
            List<Temperatura> registrosExistentes = new List<Temperatura>();
            registrosExistentes = registros.ObtenerTemperaturaPorIot(iot);
            return Ok(registrosExistentes);
        }
    }
}
