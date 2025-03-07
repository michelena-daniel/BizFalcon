using System.ComponentModel.DataAnnotations.Schema;

namespace BizFalconApi.Models
{
    [Table("deal")]
    public class Deal
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("tenantid")]
        public Guid TenantId { get; set; }
        [Column("customerid")]
        public Guid CustomerId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("stage")]
        public string Stage { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }
    }
}
