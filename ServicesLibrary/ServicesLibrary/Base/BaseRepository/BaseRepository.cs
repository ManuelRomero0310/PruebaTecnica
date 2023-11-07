using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Base.BaseRepository.IBaseRepository;
using EFCore.BulkExtensions;

namespace ServicesLibrary.Base.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly DbSet<T> _entities;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable().AsParallel();
        }

        public virtual async Task<T> GetById(int id)
        {
            T entity = await _entities.FindAsync(id);
            return entity;
        }

        public async Task Add(T entity)
        {
            var result = await _entities.AddAsync(entity);
        }

        public bool AddRange(List<T> entities)
        {
            _dbContext.AddRange(entities);
            return true;
        }

        public bool BulkInsert(List<T> entities)
        {
            _dbContext.BulkInsert(entities);
            return true;
        }

        public async Task UpdateAsync(T entity)
        {
            T prevEntity = await GetById(entity.Id);
            _dbContext.Entry(prevEntity).State = EntityState.Detached;
            _entities.Update(entity);
        }
        public async Task Delete(T entity)
        {
            _entities.Remove(entity);
        }
        public bool UpdateRange(List<T> entities)
        {
            _dbContext.UpdateRange(entities);
            return true;
        }

    }
}
