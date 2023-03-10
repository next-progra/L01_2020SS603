using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2020SS603.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2020SS603.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calificacionesController : ControllerBase
    {
        private readonly calificacionesController _calificacionesContexto;

        public calificacionesController(calificacionesController calificacionesContexto)
        {
            _calificacionesContexto = calificacionesContexto;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {

            List<calificaciones> listadoCalificaciones = (from e in _calificacionesContexto.calificaciones
                                              select e).toList();

            if (listadoCalificaciones.Count() = 0)
            {
                return NotFound();
            }
            return Ok(listadoCalificaciones);

        }
    }

    
}
