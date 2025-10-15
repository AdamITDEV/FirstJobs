using FirstJobs.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

public static class FirstJobsDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<FirstJobsDbContext> b, string cs)
        => b.UseSqlServer(cs);

    public static void Configure(DbContextOptionsBuilder<FirstJobsDbContext> b, DbConnection c)
        => b.UseSqlServer(c);
}
