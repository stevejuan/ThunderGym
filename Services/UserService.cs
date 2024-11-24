using System.Linq.Expressions;
using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using ThunderGym.Repositories;

namespace ThunderGym.Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddUser(User user)
        {
            _repositoryWrapper.UserRepository.Create(user);
        }

        public void DeleteUser(User user)
        {
            _repositoryWrapper.UserRepository.Delete(user);
        }

        public void UpdateUser(User user)
        {
            _repositoryWrapper.UserRepository.Update(user);
        }

        public List<User> GetUsers()
        {
            return _repositoryWrapper.UserRepository.FindAll().ToList();
        }
        public List<User> GetUsersByCondition(Expression<Func<User, bool>> expression)
        {
            return _repositoryWrapper.UserRepository.FindByCondition(expression).ToList();
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
