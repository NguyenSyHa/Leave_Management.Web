using Leave_Management.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leave_Management.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }

        public DbSet<Leave_Management.Web.Models.EmployeeListVM> EmployeeListVM { get; set; }

        public DbSet<Leave_Management.Web.Models.LeaveAllocationEditVM> LeaveAllocationEditVM { get; set; }

        //public DbSet<Leave_Management.Web.Models.LeaveAllocationEditVM> LeaveAllocationEditVM { get; set; }

        //public DbSet<Leave_Management.Web.Models.EmployeeAllocationVM> EmployeeAllocationVM { get; set; }
    }
}