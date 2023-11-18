using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Univi.Server.Models;
using Univi.Shared;

namespace Univi.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Handover> Handovers { get; set; }
        public DbSet<KeyIssue> KeyIssues { get; set; }
        public DbSet<KeyList> KeysList { get; set; }
        public DbSet<KindOfReport> KindOfReports { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Building> Buidlings { get; set; }
        public DbSet<Malfunction> Malfunctions { get; set; }
        public DbSet<KindofMalfunction> KindofMalfunctions { get; set; }
        public DbSet<StatusCode> StatusCodes { get; set; }


    }
}