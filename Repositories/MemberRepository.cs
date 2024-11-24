using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
