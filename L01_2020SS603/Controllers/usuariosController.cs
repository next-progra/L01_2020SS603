using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2020SS603.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2020SS603.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private readonly usuariosController _usuariosContexto;

        public usuariosController(usuariosController usuariosContexto)
        {
            _usuariosContexto = usuariosContexto;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {

            List<usuarios> listadoUsuarios = (from e in _usuariosContexto.usuarios
                                              select e).toList();

            if (listadoUsuarios.Count() = 0)
            {
                return NotFound();
            }
            return Ok(listadoUsuarios);

        }
    }

    
}
