using ServicesLibrary.Models;
using ServicesLibrary.Models.BaseClass;

namespace ServicesLibrary.Services.IServices
{
    public interface IBooksService
    {
        Task<List<BooklViewAll>> GetAllAndAuthors();
        Task<Books> Post(Books books);
    }
}
