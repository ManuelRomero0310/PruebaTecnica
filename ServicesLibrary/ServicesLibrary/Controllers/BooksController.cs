using Microsoft.AspNetCore.Mvc;
using ServicesLibrary.Models.BaseClass;
using ServicesLibrary.Services;
using ServicesLibrary.Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        /// <summary>
        /// Operación Consultar todos los Libros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<BooklViewAll>> Get()
        {
            var authors = await _booksService.GetAllAndAuthors();
            return authors;
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
        /// Operación Guardar un Libro
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public async Task<IActionResult> Post(Models.Books books)
        {
            if (string.IsNullOrEmpty(books.Titulo))
                return Ok("Ingrese el Titulo del libro");

            if (books.IdAutor == 0)
                return Ok("Ingrese el nombre del autor del libro");

            var result = await _booksService.Post(books);
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
