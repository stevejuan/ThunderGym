using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using System.Linq.Expressions;

namespace ThunderGym.Services
{
    public class MemberService : IMemberService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MemberService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddMember(Member member)
        {
            _repositoryWrapper.MemberRepository.Create(member);
        }

        public void UpdateMember(Member member)
        {
            _repositoryWrapper.MemberRepository.Update(member);
        }

        public void DeleteMember(Member member)
        {
            _repositoryWrapper.MemberRepository.Delete(member);
        }

        public List<Member> GetMembers()
        {
            return _repositoryWrapper.MemberRepository.FindAll().ToList();
        }
        public List<Member> GetMembersByCondition(Expression<Func<Member, bool>> expression)
        {
            return _repositoryWrapper.MemberRepository.FindByCondition(expression).ToList();
        }

        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
