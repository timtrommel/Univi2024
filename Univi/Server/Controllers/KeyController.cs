using Microsoft.AspNetCore.Mvc;
using Univi.Server.Services.KeyService;
using Univi.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeyController : ControllerBase
    {
        #region CTOR
        private readonly IKeyservice _service;

        public KeyController(IKeyservice service)
        {
            _service = service;
        }
        #endregion

        #region GET
        [HttpGet]
        public async Task<List<KeyIssue>> GetKeyIssues()
        {
            return await _service.GetKeyIssues();
        }
        [HttpGet("GetLatest5")]
        public ActionResult<KeyIssue> GetLatest5KeyIssues()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Keylist")]
        public async Task<List<KeyList>> GetKeyList()
        {
            return await _service.GetKeyList();

        }

        [HttpGet]
        [Route("ActiveKeylist")]
        public async Task<List<KeyList>> GetReturnedKeys()
        {
            return await _service.GetReturnedKeys();
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<KeyIssue?> AddKeyIssue(KeyIssue key)
        {
            return await _service.CreateKeyIssue(key);
        }

        [HttpPost("inactive")]
        public async Task<KeyIssue?> SetItemInactive([FromBody] string id)
        {
            var result = await _service.SetKeyReturned(id);
            return result;
        }

        #endregion
    }

}
