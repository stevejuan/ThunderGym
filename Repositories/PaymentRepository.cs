using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;

namespace ThunderGym.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(GymContext gymContext)
            : base(gymContext)
        {
        }
    }
}
