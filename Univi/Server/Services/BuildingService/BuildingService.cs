using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.BuildingService
{
    public class BuildingService : IBuildingService
    {
        private readonly ApplicationDbContext _context;

        public BuildingService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Building?> CreateBuilding(Building building)
        {
            var result = new Building
            {
                Name = building.Name,
                Adress = building.Adress,
                PostalCode= building.PostalCode,
                City= building.City,
                Province=building.Province,
                Country=building.Country,
            };
            if (result != null)
            {
                await _context.Buidlings.AddAsync(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;

        }

        public async Task<Building?> GetBuildingByID(int id)
        {
            var result = await _context.Buidlings.FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public async Task<List<Building>> GetBuildings()
        {
            var result = await _context.Buidlings.ToListAsync();
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public Task<Building?> UpdateBuilding(Building building)
        {
            throw new NotImplementedException();
        }

        public Task<Department?> UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
