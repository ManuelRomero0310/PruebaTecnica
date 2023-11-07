using ServicesLibrary.Models;

namespace ServicesLibrary.Services.IServices
{
    public interface IAuthorsService
    {
        Task<List<Authors>> GetAll();
        Task<Authors> Post(Authors authors);
    }
}
