using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using System.Linq.Expressions;

namespace ThunderGym.Services
{
    public class TrainerService : ITrainerService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TrainerService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddTrainer(Trainer trainer)
        {
            _repositoryWrapper.TrainerRepository.Create(trainer);
        }

        public void UpdateTrainer(Trainer trainer)
        {
            _repositoryWrapper.TrainerRepository.Update(trainer);
        }

        public void DeleteTrainer(Trainer trainer)
        {
            _repositoryWrapper.TrainerRepository.Delete(trainer);
        }

        public List<Trainer> GetTrainer()
        {
            return _repositoryWrapper.TrainerRepository.FindAll().ToList();
        }
        public List<Trainer> GetTrainerByCondition(Expression<Func<Trainer, bool>> expression)
        {
            return _repositoryWrapper.TrainerRepository.FindByCondition(expression).ToList();
        }

        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
