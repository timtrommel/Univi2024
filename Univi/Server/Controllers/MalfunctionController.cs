using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univi.Server.Services.MalfunctionService;
using Univi.Shared;

namespace Univi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MalfunctionController : ControllerBase
    {
        private readonly IMalfunctionService _service;

        public MalfunctionController(IMalfunctionService service)
        {
            _service = service;
        }

        #region httpGet
        [HttpGet]
        public async Task<List<Malfunction>> GetMalfunctions()
        {
            return await _service.GetMalfunctions();
        }
        [HttpGet("kindofmalfunctions")]
        public async Task<List<KindofMalfunction>> GetKindofMalfunctions()
        {
            return await _service.GetKindofMalfunctions();
        }

        #endregion

        #region httpPost
        [HttpPost]
        public async Task<Malfunction> PostMalfunction([FromBody] Malfunction malfunction)
        {
            return await _service.CreateMalfunction(malfunction);
        }

        #endregion
    }
}
