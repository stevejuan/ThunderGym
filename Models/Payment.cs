namespace ThunderGym.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int MemberId { get; set; }
        public DateTime? PaymentDate { get; set; }

    }
}
