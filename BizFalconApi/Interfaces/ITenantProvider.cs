namespace BizFalconApi.Interfaces
{
    public interface ITenantProvider
    {
        Guid? TenantId { get; set; }
    }
}
