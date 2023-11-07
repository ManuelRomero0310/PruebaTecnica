using Microsoft.AspNetCore.Mvc;
using ServicesLibrary.Models;
using ServicesLibrary.Services.IServices;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;
        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        /// <summary>
        /// Operación Consultar todos los Autores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var authors = await _authorsService.GetAll();
            return Ok(authors);
        }

        /// <summary>
        /// Operación no implementada
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Operacion guardar Autor
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public async Task<IActionResult> Post(Authors author)
        {
            if (string.IsNullOrEmpty(author.Nombre))
                return Ok("Ingrese el Nombre del autor");

            var result = await _authorsService.Post(author);
            return Ok(result);
        }

        /// <summary>
        /// Operación no implementada
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Operación no implementada
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
