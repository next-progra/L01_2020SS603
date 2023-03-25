using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2020SS603.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2020SS603.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class comentariosController : ControllerBase
    {
        private readonly comentariosController _comentariosContexto;

        public comentariosController(comentariosController comentariosContexto)
        {
            _comentariosContexto = comentariosContexto;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {

            List<comentarios> listadoComentarios = (from e in _usuariosContexto.comentarios
                                              select e).toList();

            if (listadoComentarios.Count() = 0)
            {
                return NotFound();
            }
            return Ok(listadoComentarios);

        }
    }

    
}
