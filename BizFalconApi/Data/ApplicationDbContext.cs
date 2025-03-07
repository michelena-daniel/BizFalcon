using BizFalconApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BizFalconApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // FK for many to many
            modelBuilder.Entity<UserDeal>()
                .HasKey(ud => new { ud.UserId, ud.DealId });
        }

        // RLS
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var tenantId = _httpContextAccessor.HttpContext?.Items["TenantId"] as Guid?;
            if (tenantId.HasValue)
            {
                await Database.ExecuteSqlRawAsync($"SET app.tenant_id = '{tenantId.Value}';");
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
