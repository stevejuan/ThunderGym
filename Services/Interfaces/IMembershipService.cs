using System.Linq.Expressions;
using ThunderGym.Models;

namespace ThunderGym.Services.Interfaces
{
    public interface IMembershipService
    {
        List<Membership> GetMemberships();
        List<Membership> GetMembershipsByCondition(Expression<Func<Membership, bool>> expression);
        void AddMembership(Membership membership);
        void UpdateMembership(Membership membership);
        void DeleteMembership(Membership membership);
        void Save();
    }
}
