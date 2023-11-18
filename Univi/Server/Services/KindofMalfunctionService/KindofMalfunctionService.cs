using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.KindofMalfunctionService
{
    public class KindofMalfunctionService : IKindofMalfunctionService
    {
        private readonly ApplicationDbContext _context;

        public KindofMalfunctionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<KindofMalfunction> CreateKindofMalfunction(KindofMalfunction kindofMalfunction)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KindofMalfunction>> GetKindofMalfunctions()
        {
            var result = await _context.KindofMalfunctions.ToListAsync();
            return result;
        }

        public async Task<List<Malfunction>> GetMalfunctions()
        {
            var result = await _context.Malfunctions.ToListAsync();
            return result;
        }
    }

}
