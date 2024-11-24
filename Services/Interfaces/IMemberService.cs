using System.Linq.Expressions;
using ThunderGym.Models;
namespace ThunderGym.Services.Interfaces
{
    public interface IMemberService
    {
        List<Member> GetMembers();
        List<Member> GetMembersByCondition(Expression<Func<Member, bool>> expression);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
        void Save();
    }
}
