using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using System.Linq.Expressions;

namespace ThunderGym.Services
{
    public class ClassService : IClassService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ClassService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddClass(Class sclass)
        {
            _repositoryWrapper.ClassRepository.Create(sclass);
        }

        public void UpdateClass(Class sclass)
        {
            _repositoryWrapper.ClassRepository.Update(sclass);
        }

        public void DeleteClass(Class sclass)
        {
            _repositoryWrapper.ClassRepository.Delete(sclass);
        }

        public List<Class> GetClasses()
        {
            return _repositoryWrapper.ClassRepository.FindAll().ToList();
        }
        public List<Class> GetClassesByCondition(Expression<Func<Class, bool>> expression)
        {
            return _repositoryWrapper.ClassRepository.FindByCondition(expression).ToList();
        }

        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
