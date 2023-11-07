using DocumentFormat.OpenXml.Spreadsheet;
using ServicesLibrary.Base.BaseRepository.IBaseRepository;
using ServicesLibrary.Base.BaseService;
using ServicesLibrary.Models;
using ServicesLibrary.Models.BaseClass;
using ServicesLibrary.Services.IServices;

namespace ServicesLibrary.Services
{
    public class BooksService : BaseService<Books>, IBooksService
    {
        public BooksService(IUnitRepository unitRepository) : base(unitRepository) { }

        public async Task<List<BooklViewAll>> GetAllAndAuthors()
        {
            var books = _unitRepository.booksRepository.GetAll().ToList();
            List<BooklViewAll> viewBooks_Authors = new List<BooklViewAll>();

            foreach (var book in books) 
            {
                Models.Authors nameAuthor = await _unitRepository.authorsRepository.GetById(book.IdAutor);

                if(nameAuthor != null)
                    viewBooks_Authors.Add(new BooklViewAll { Titulo = book.Titulo, Id = book.Id, NombreAutor = nameAuthor.Nombre });
            }
            return viewBooks_Authors;
        }

        public async Task<Books> Post(Books books)
        {
            if (string.IsNullOrEmpty(books.Titulo))
                throw new Exception("Agregue el Nombre del autor");

            if(books.IdAutor == 0)
                throw new Exception("Agregue el Nombre del autor");

            await _unitRepository.booksRepository.Add(books);
            _unitRepository.SaveChanges();
            return books;
        }
    }
}
