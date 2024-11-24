using System.Linq.Expressions;
using ThunderGym.Models;
namespace ThunderGym.Services.Interfaces
{
    public interface ITrainerService
    {
        List<Trainer> GetTrainer();
        List<Trainer> GetTrainerByCondition(Expression<Func<Trainer, bool>> condition);

        void AddTrainer(Trainer trainer);

        void UpdateTrainer(Trainer trainer);

        void DeleteTrainer(Trainer trainer);

        void Save();
    }
}
