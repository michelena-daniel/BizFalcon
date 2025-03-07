using BizFalconApi.Interfaces;
using Microsoft.Extensions.Primitives;

namespace BizFalconApi.Middlewares
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // Middleware to manage RLS (row level security), we inject the tenantId to send it on each http request
        public async Task Invoke(HttpContext context, ITenantProvider tenantProvider)
        {
            if (context.Request.Headers.TryGetValue("X-Tenant-ID", out StringValues tenantIdValues))
            {
                if (Guid.TryParse(tenantIdValues.FirstOrDefault(), out Guid tenantId))
                {
                    tenantProvider.TenantId = tenantId;
                }
            }

            await _next(context);
        }
    }
}
