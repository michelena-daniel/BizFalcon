using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizFalconApi.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("tenantid")]
        public Guid TenantId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
    }
}
