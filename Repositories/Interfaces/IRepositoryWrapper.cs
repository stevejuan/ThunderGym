namespace ThunderGym.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAdminRepository AdminRepository { get; }
        IClassRepository ClassRepository { get; }   
        IMemberRepository MemberRepository { get; }
        IMembershipRepository MembershipRepository { get; }
        IUserRepository UserRepository { get; } 
        IPaymentRepository PaymentRepository { get; }
        ITrainerRepository TrainerRepository { get; }
        void Save();
    }
    
}
