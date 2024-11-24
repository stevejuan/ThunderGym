using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using System.Linq.Expressions;

namespace ThunderGym.Services
{
    public class MembershipService : IMembershipService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MembershipService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddMembership(Membership membership)
        {
            _repositoryWrapper.MembershipRepository.Create(membership);
        }

        public void UpdateMembership(Membership membership)
        {
            _repositoryWrapper.MembershipRepository.Update(membership);
        }

        public void DeleteMembership(Membership membership)
        {
            _repositoryWrapper.MembershipRepository.Delete(membership);
        }

        public List<Membership> GetMemberships()
        {
            return _repositoryWrapper.MembershipRepository.FindAll().ToList();
        }
        public List<Membership> GetMembershipsByCondition(Expression<Func<Membership, bool>> expression)
        {
            return _repositoryWrapper.MembershipRepository.FindByCondition(expression).ToList();
        }

        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
