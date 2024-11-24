using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
        public AdminRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
