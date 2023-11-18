using Microsoft.AspNetCore.Mvc;
using Univi.Server.Services.KindofReportService;
using Univi.Server.Services.ReportService;
using Univi.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        #region CTOR
        private readonly IReportService _reportService;
        private readonly IKindofReportService _kindofreportService;

        public ReportController(IReportService reportService, IKindofReportService kindofreportService)
        {
            _reportService = reportService;
            _kindofreportService = kindofreportService;
        }
        #endregion
        #region HttpGet
        [HttpGet]
        public async Task<List<Report>> GetReports()
        {
            return await _reportService.GetReports();
        }

        [HttpGet("kindofreport")]
        public async Task<List<KindOfReport>> GetKindofReports()
        {
           return await  _kindofreportService.GetKindofReports();
        }

        [HttpGet("{id}")]
        public async Task<Report?> GetReportById(int id)
        {
            return await _reportService.GetReportById(id);
        }

        #endregion
        #region HttpPost
        //Create a new report
        [HttpPost]
        public async Task<Report?> CreateReport(Report report)
        {
            return await _reportService.CreateReport(report);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public async Task<Report?> UpdateProduct(Report report)
        {
            var result = await _reportService.UpdateReport(report);
            return result;

        }
        #endregion
    }
}
