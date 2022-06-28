using Microsoft.AspNetCore.Mvc;
using SampleCQRS.Application;

namespace SampleCQRS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
    }
}