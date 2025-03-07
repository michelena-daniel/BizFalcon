using System.ComponentModel.DataAnnotations;

namespace BizFalconApi.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "SalesRep";
    }
}
