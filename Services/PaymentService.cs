using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;
using System.Linq.Expressions;

namespace ThunderGym.Services
{
    public class PaymentService : IPaymentService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public PaymentService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddPayment(Payment payment)
        {
            _repositoryWrapper.PaymentRepository.Create(payment);
        }

        public void UpdatePayment(Payment payment)
        {
            _repositoryWrapper.PaymentRepository.Update(payment);
        }

        public void DeletePayment(Payment payment)
        {
            _repositoryWrapper.PaymentRepository.Delete(payment);
        }

        public List<Payment> GetPayments()
        {
            return _repositoryWrapper.PaymentRepository.FindAll().ToList();
        }
        public List<Payment> GetPaymentsByCondition(Expression<Func<Payment, bool>> expression)
        {
            return _repositoryWrapper.PaymentRepository.FindByCondition(expression).ToList();
        }

        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
