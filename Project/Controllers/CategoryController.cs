using Microsoft.AspNetCore.Mvc;
using Bll_Services;
using Microsoft.AspNetCore.Http;
namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        ICategoryBll c;

        public CategoryController(ICategoryBll ca)
        {
            this.c = ca;
        }


        [HttpGet(Name = "getCategoryList")]
        public async Task<List<Dto_Common_Enteties.CategoryDto>> Get()
        {

            return await c.SelectAllAsync();
        }
    }
}
