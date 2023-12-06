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

        #region POST
        public async Task<Handover?> CreateHandover(Handover handover)
        {
            var AddHandover = new Handover
            {
                DateCreated = DateTime.Now,
                DateHandover = handover.DateHandover,
                AddedById = handover.AddedById,
                DateLastEdit = DateTime.Now,
                Title = handover.Title,
                Description = handover.Description,
                IsActive = true,
                KindofHandoverId = handover.KindofHandoverId,
                //If there is a related reportnumber, the user could select it.
                ReportNo = handover.ReportNo == null || string.IsNullOrEmpty(handover.ReportNo) ? "N.v.t" : handover.ReportNo,
                //Check if the nostatend is false, tthen set the dates and times
                StartDate = handover.NoStartEnd == false ? handover.StartDate : default,
                StartTime = handover.NoStartEnd == false ? handover.StartTime : default,
                EndDate = handover.NoStartEnd == false ? handover.EndDate : default,
                EndTime = handover.NoStartEnd == false ? handover.EndTime : default,
                NoStartEnd = handover.NoStartEnd
            };
            await _context.Handovers.AddAsync(AddHandover);
            await _context.SaveChangesAsync();
            return handover;

        }
        #endregion
    }
}
