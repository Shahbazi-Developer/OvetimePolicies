using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OvetimePolicies.Infra.Data.Sql.Commands.Common;

public class OvetimePoliciesCommandDbContextFactory : IDesignTimeDbContextFactory<OvetimePoliciesCommandDbContext>
{
    public OvetimePoliciesCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<OvetimePoliciesCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=OvetimePoliciesDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

        return new OvetimePoliciesCommandDbContext(builder.Options);
    }
}