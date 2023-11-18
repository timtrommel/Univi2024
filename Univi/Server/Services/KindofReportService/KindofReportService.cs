using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.KindofReportService
{
    public class KindofReportService : IKindofReportService
    {
        private readonly ApplicationDbContext _context;

        public KindofReportService(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task<KindOfReport?> CreateKindofReport(KindOfReport kindofreport)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KindOfReport>> GetKindofReports()
        {
            var result = await _context.KindOfReports.ToListAsync();
            return result;
        }

        public async Task<KindOfReport?> GetKindofReporttById(int id)
        {
            var result = await _context.KindOfReports.FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
