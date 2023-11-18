using Microsoft.AspNetCore.Mvc;
using Univi.Server.Data;
using Univi.Server.Services.BuildingService;
using Univi.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _service;

        public BuildingController(IBuildingService service)
        {
            _service = service;
        }

        // GET: DepartmentController
        [HttpGet]
        public async Task<List<Building>> GetBuildings()
        {
            return await _service.GetBuildings();
        }
    }
}
