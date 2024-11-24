using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class TrainerRepository : RepositoryBase<Trainer>, ITrainerRepository
    {
        public TrainerRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
