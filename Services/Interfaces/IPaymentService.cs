using System.Linq.Expressions;
using ThunderGym.Models;
namespace ThunderGym.Services.Interfaces
{
    public interface IPaymentService
    {
        List<Payment> GetPayments();
        List<Payment> GetPaymentsByCondition(Expression<Func<Payment, bool>> expression);
        void AddPayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(Payment payment);
        void Save();
    }
}
