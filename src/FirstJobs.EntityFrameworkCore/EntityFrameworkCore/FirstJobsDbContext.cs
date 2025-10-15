// EntityFrameworkCore/FirstJobsDbContext.cs
using FirstJobs.Authorization.Roles;
using FirstJobs.Authorization.Users;
using FirstJobs.MultiTenancy;
using FirstJobs.Phones;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using FirstJobs.Contacts;

public class FirstJobsDbContext : Abp.Zero.EntityFrameworkCore.AbpZeroDbContext<Tenant, Role, User, FirstJobsDbContext>
{
    public DbSet<Contact> Contacts { get; set; }
    public FirstJobsDbContext(DbContextOptions<FirstJobsDbContext> options) : base(options) { }
}
