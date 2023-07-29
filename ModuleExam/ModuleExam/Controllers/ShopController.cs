using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModuleExam.Data;
using ModuleExam.Services;
using static ModuleExam.Services.IShopService;

namespace ModuleExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;

        }

        [HttpPost]
        public ActionResult<Shop> CreateShop([FromBody] Shop shop)
        {


            _shopService.CreateShop(shop);
            return NoContent();
        }

        [HttpGet]
        public ActionResult<List<Shop>> GetShop()
        {
            var response = _shopService.GetAllShop();
            return Ok(response);
        }

        [HttpDelete("id")]
        public ActionResult DeleteShop([FromQuery] int id)
        {

            _shopService.DeleteShop(id);
            return NoContent();
        }

        [HttpPut("id")]
        public ActionResult UpdateShop(int id, [FromBody] Shop shop)
        {
            _shopService.UpdateShop(id, shop);
            return NoContent();
        }
    }
}
