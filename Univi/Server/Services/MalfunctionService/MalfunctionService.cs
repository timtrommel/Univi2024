using Microsoft.EntityFrameworkCore;
using System.Data;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.MalfunctionService
{
    public class MalfunctionService : IMalfunctionService
    {
        private readonly ApplicationDbContext _context;

        public MalfunctionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public  Task<Malfunction> CreateMalfunction(Malfunction malfunction)
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
