using System.ComponentModel.DataAnnotations;

namespace BizFalconApi.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
