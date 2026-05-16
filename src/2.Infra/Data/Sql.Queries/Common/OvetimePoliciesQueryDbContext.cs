using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace OvetimePolicies.Infra.Data.Sql.Queries.Common;

public class OvetimePoliciesQueryDbContext : BaseQueryDbContext
{
    public OvetimePoliciesQueryDbContext(DbContextOptions<OvetimePoliciesQueryDbContext> options) : base(options)
    {
    }
}