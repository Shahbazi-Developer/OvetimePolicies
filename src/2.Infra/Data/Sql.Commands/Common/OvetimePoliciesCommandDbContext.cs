using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace OvetimePolicies.Infra.Data.Sql.Commands.Common;

public class OvetimePoliciesCommandDbContext : BaseOutboxCommandDbContext
{
    public OvetimePoliciesCommandDbContext(DbContextOptions<OvetimePoliciesCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}