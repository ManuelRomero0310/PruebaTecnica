using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Base.BaseRepository;
using ServicesLibrary.Models;
using ServicesLibrary.Repository.IRepository;

namespace ServicesLibrary.Repository
{
    public class AuthorsRepository : BaseRepository<Authors>, IAuthorsRepository
    {
        public AuthorsRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
