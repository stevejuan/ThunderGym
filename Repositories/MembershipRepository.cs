using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class MembershipRepository : RepositoryBase<Membership>, IMembershipRepository
    {
        public MembershipRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
