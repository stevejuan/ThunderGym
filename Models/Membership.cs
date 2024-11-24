namespace ThunderGym.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public int Price { get; set; }
        public string Duration { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
