using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataValidator.Data.Interfaces.Managers
{
    public interface IManager<TEntity>
    {
        public Task<TEntity> AddNew(TEntity newEntity);

        public IEnumerable<TEntity> GetAll();

        public Task<TEntity> Update(TEntity updateEntity);
    }
}
