using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.HandoverService
{
    public class HandoverService : IHandoverService
    {
        #region CTOR
        private readonly ApplicationDbContext _context;

        public HandoverService(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region GET
        //Get a list of all handovers
        public async Task<List<Handover>> GetHandovers()
        {
            var result = await _context.Handovers.ToListAsync();
            return result;
        }
        #endregion
    }
}
