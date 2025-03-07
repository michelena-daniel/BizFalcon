using System.ComponentModel.DataAnnotations;

namespace BizFalconApi.Models
{
    public class Tenant
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Subdomain { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
