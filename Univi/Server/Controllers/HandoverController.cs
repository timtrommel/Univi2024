using Microsoft.AspNetCore.Mvc;
using Univi.Server.Services.HandoverService;
using Univi.Shared;

namespace Univi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandoverController : ControllerBase
    {
        #region CTOR
        private readonly IHandoverService _HandoverService;

        public HandoverController(IHandoverService HandoverService)
        {
            _HandoverService = HandoverService;
        }
        #endregion

        #region GET
        //Get a list of all handovers
        [HttpGet]
        public async Task<List<Handover>> GetHandovers()
        {
            return await _HandoverService.GetHandovers();
        }
        //Get a single handover by id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        #endregion

        #region POST
        // Post a new handover
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        #endregion

        #region PUT
        // Edit a handover
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        #endregion

        #region DELETE
        // Delete handover by id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
