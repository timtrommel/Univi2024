using Univi.Shared;

namespace Univi.Server.Services.BuildingService
{
    public interface IBuildingService
    {
        Task<List<Building>> GetBuildings();
        Task<Building?> GetBuildingByID(int id);
        Task<Building?> CreateBuilding(Building building);
        Task<Building?> UpdateBuilding(Building building);
    }
}
