using APIServ.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIServ.Controllers
{
    [ApiController]
    [Route("[controller] /action ")]
    public class BrandController : ControllerBase
    {
        private readonly ILogger<BrandController> _logger;
        private readonly IBrandService _brandService;
        public BrandController(ILogger<BrandController> logger, IBrandService brandService)
        {
            _logger = logger;
            _brandService = brandService;
        }

        [HttpPost(Name = "InsertBrand")]
        public int Post([FromBody] BrandItem brandItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _brandService.InsertBrand(brandItem);
        }
        [HttpGet(Name = "GetAllBrand")]
        public List<BrandItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _brandService.GetAllBrand();
        }
        [HttpPatch(Name = "ModifyBrand")]
        public void Patch([FromBody] BrandItem brandItem)
        {
            _brandService.UpdateBrand(brandItem);

        }
        [HttpDelete(Name = "DeleteBrand")]
        public void Delete([FromQuery] int id)
        {
            _brandService.DeleteBrand(id);

        }
    }
}
     
        


    