using ServicesLibrary.Base.BaseRepository.IBaseRepository;
using ServicesLibrary.Repository;
using ServicesLibrary.Repository.IRepository;

namespace ServicesLibrary.Base.BaseRepository
{
    public class UnitRepository : IUnitRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IAuthorsRepository _authorsRepository;
        private readonly IBooksRepository _booksRepository;

        public UnitRepository(
        ApplicationDbContext dbContext
        )
        {
            _dbContext = dbContext;
        }

        public IAuthorsRepository authorsRepository => _authorsRepository ?? new AuthorsRepository(_dbContext);
        public IBooksRepository booksRepository => _booksRepository ?? new BooksRepository(_dbContext);

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            _dbContext.SaveChangesAsync();
        }

        public Task SaveChangesInBackGroundAsync()
        {
            throw new NotImplementedException();
        }
    }
}
