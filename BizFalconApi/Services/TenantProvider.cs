using BizFalconApi.Interfaces;

namespace BizFalconApi.Services
{
    public class TenantProvider : ITenantProvider
    {
        public Guid? TenantId { get; set; }
    }
}
