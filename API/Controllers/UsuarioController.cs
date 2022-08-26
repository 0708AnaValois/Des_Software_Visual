using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        //using System.Linq;
        private static List<Usuario> usuarios = new List<Usuario>();

        //GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            Usuario usuario = new Usuario();
        
        
            return Ok(usuario);
        }

        //POST: /api/usuario/cadastrar
        [HttpPost]
        [Route ("Cadastrar")]
        public IActionResult Cadastrar([FromBody]Usuario usuario)
        {
            return Create("", usuario);
        }

        [HttpGet]
        [Route("buscar/{login}")]
        public IActionResult Buscar([FromRoute] string login)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if(usuarios[i].Login.Equals(login))
                {
                    return Ok(usuarios[i]);
                }
            }
            return NotFound();
        }
    }
}
