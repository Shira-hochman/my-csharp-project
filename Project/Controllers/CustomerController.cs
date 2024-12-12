using Bll_Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerBll b;
        public CustomerController(ICustomerBll c)
        {
            this.b = c;
        }

        [HttpGet(Name = "getCustomer")]
        public async Task<List<Dto_Common_Enteties.CustomerDto>> Get()
        {

            return await b.SelectAllAsync();
        }
        [HttpPost("customerPost")]
        public async Task Post(Dto_Common_Enteties.CustomerDto cu)
        {

            await b.AddAsync(cu);

        }
    }
}
