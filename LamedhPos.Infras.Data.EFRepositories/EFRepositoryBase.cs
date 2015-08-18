using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.EFRepositories
{
    public abstract class EFRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected LamedhPosContext posContext;

        public EFRepositoryBase()
        {
            posContext = new LamedhPosContext();
        }

        public TEntity GetById(int id)
        {
            return GetDbSet().Single(e => e.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return GetDbSet();
        }

        public void Save(TEntity entity)
        {
            GetDbSet().Add(entity);
            posContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            GetDbSet().Remove(entity);
            posContext.SaveChanges();
        }

        public void Dispose()
        {
            posContext.Dispose();
        }

        protected abstract DbSet<TEntity> GetDbSet();
    }
}
