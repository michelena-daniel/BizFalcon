using System.ComponentModel.DataAnnotations.Schema;

namespace BizFalconApi.Models
{
    [Table("users_deals")]
    public class UserDeal
    {
        [Column("userid")]
        public Guid UserId { get; set; }
        [Column("dealid")]
        public Guid DealId { get; set; }
        [Column("assignedat")]
        public DateTime AssignedAt { get; set; }

    }
}
