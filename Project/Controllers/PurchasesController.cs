using Bll_Services;
using Dto_Common_Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        IPurchasesBll p;

        public PurchasesController(IPurchasesBll p)
        {
            this.p = p;
        }

        [HttpPost("purchasesPost")]
        public async Task<ActionResult<PurchasesDto>> AddPayAsync(PurchasesDto pu)
        {
            try
            {
                var addedPurchase = await p.AddPayAsync(pu); // עכשיו הפונקציה מחזירה את ה-DTO עם ה-ID המעודכן

                return Ok(addedPurchase);  // מחזיר את ה-DTO עם ה-ID המעודכן
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }





    }
}
