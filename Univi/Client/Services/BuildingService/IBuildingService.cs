using Univi.Shared;

namespace Univi.Client.Services.BuildingService
{
    public interface IBuildingService
    {
        List<Building> Buildings { get; }
        Task GetBuildings();
    }
}
