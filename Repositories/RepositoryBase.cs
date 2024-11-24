using System.Linq.Expressions;
using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ThunderGym.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected GymContext GymContext { get; set; }

        public RepositoryBase(GymContext gymContext)
        {
            this.GymContext = gymContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.GymContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.GymContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.GymContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.GymContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.GymContext.Set<T>().Remove(entity);
        }
    }

}