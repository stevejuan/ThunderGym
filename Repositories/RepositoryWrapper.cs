using ThunderGym.Repositories.Interfaces;
using ThunderGym.Models;

namespace ThunderGym.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private GymContext _dbContext;


        private IAdminRepository _adminRepository;
        private IClassRepository? _classRepository;
        private IUserRepository? _userRepository;
        private ITrainerRepository? _trainerRepository;
        private IMemberRepository? _memberRepository;
        private IMembershipRepository? _membershipRepository;
        private IPaymentRepository? _paymentRepository;

        public IAdminRepository AdminRepository
        {
            get
            {
                if (_adminRepository == null)
                {
                    _adminRepository = new AdminRepository(_dbContext);
                }
                return _adminRepository;
            }
        }
        public IClassRepository ClassRepository
        {
            get
            {
                if (_classRepository == null)
                {
                    _classRepository = new ClassRepository(_dbContext);
                }
                return _classRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_dbContext);
                }

                return _userRepository;
            }
        }

        public IMemberRepository MemberRepository
        {
            get
            {
                if (_memberRepository == null)
                {
                    _memberRepository = new MemberRepository(_dbContext);
                }
                return _memberRepository;
            }
        }

        public IMembershipRepository MembershipRepository
        {
            get
            {
                if (_membershipRepository == null)
                {
                    _membershipRepository = new MembershipRepository(_dbContext);

                }
                return _membershipRepository;
            }
        }

        public ITrainerRepository TrainerRepository
        {
            get
            {
                if (_trainerRepository == null)
                {
                    _trainerRepository = new TrainerRepository(_dbContext);
                }

                return _trainerRepository;

            }
        }
        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                {
                    _paymentRepository = new PaymentRepository(_dbContext);
                }

                return _paymentRepository;

            }
        }
        public RepositoryWrapper(GymContext? dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
