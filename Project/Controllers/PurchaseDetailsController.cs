using Bll_Services;
using Dal_Repository.models;
using Dto_Common_Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Dal_Repository.modelsConverters;
using Dal_Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseDetailsController : ControllerBase
    {
        private readonly IPurchaseDetailsBll _service;

        public PurchaseDetailsController(IPurchaseDetailsBll service)
        {
            _service = service;
        }

        [HttpPost("PurchaseDetailsPost")]
        public async Task<IActionResult> PostPurchaseDetails([FromBody] List<PurchaseDetailsDto> purchaseDetailsList)
        {
           
                await _service.AddDetailsAsync(purchaseDetailsList);
                return Ok(purchaseDetailsList); // מחזירים את הנתונים שהתקבלו
            
        }
    }


}
