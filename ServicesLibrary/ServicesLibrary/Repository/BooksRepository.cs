using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Base.BaseRepository;
using ServicesLibrary.Models;
using ServicesLibrary.Repository.IRepository;

namespace ServicesLibrary.Repository
{
    public class BooksRepository : BaseRepository<Books>, IBooksRepository
    {
        public BooksRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
