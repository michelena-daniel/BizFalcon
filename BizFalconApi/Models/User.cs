using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizFalconApi.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("tenantid")]
        public Guid TenantId { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("passwordhash")]
        public string PasswordHash { get; set; }
        [Column("role")]
        public string Role { get; set; } = "SalesRep";
    }
}
