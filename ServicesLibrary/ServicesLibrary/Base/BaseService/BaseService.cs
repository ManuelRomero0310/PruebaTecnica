using ServicesLibrary.Base.BaseRepository.IBaseRepository;
using ServicesLibrary.Base.BaseRepository;

namespace ServicesLibrary.Base.BaseService
{
    public class BaseService<TEntity> where TEntity : BaseModel
    {
        protected readonly IUnitRepository _unitRepository;
        public BaseService(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }
    }
}
