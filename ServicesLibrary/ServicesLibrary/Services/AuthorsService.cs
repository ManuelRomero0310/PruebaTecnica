using ServicesLibrary.Base.BaseRepository.IBaseRepository;
using ServicesLibrary.Base.BaseService;
using ServicesLibrary.Models;
using ServicesLibrary.Services.IServices;

namespace ServicesLibrary.Services
{
    public class AuthorsService : BaseService<Authors>, IAuthorsService
    {
        public AuthorsService(IUnitRepository unitRepository) : base(unitRepository) { }

        public async Task<List<Authors>> GetAll()
        {
            var authors = _unitRepository.authorsRepository.GetAll().ToList();

            if (authors == null || authors.Count() == 0)
                throw new Exception("Lista vacia");

            return authors;
        }

        public async Task<Authors> Post(Authors authors)
        {
            if(string.IsNullOrEmpty(authors.Nombre))
                throw new Exception("Agregue el Nombre del autor");

            await _unitRepository.authorsRepository.Add(authors);
            _unitRepository.SaveChanges();
            return authors;
        }

    }
}
