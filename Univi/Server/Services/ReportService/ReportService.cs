using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly ApplicationDbContext _context;

        public ReportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Report?> CreateReport(Report report)
        {
            throw new NotImplementedException();
        }

        public Task<Report?> GetReportById(int id)
        {
            throw new NotImplementedException();
        }

        //Get a list of reports from the database
        public async Task<List<Report>> GetReports()
        {
            var result = await _context.Reports.ToListAsync();
            return result;
        }

        public Task<Report?> UpdateReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
