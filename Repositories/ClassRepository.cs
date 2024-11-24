using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public ClassRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
