using ServicesLibrary.Repository.IRepository;

namespace ServicesLibrary.Base.BaseRepository.IBaseRepository
{
    public interface IUnitRepository
    {
        IAuthorsRepository authorsRepository { get; }
        IBooksRepository booksRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
        Task SaveChangesInBackGroundAsync();
    }
}
