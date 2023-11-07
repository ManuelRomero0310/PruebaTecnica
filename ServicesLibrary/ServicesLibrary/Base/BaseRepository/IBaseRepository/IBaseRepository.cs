namespace ServicesLibrary.Base.BaseRepository.IBaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        bool AddRange(List<T> entities);
        bool BulkInsert(List<T> entities);
        Task UpdateAsync(T entity);
        Task Delete(T entity);
        bool UpdateRange(List<T> entities);
    }
}
