namespace BizFalconApi.Models
{
    public class UserDeal
    {
        public Guid UserId { get; set; }
        public Guid DealId { get; set; }
        public DateTime AssignedAt { get; set; }

    }
}
