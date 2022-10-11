using LocalizationExample.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationExample.Controllers
{
    public class TestController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _sharedResourceLocalizer;

        public TestController(IStringLocalizer<SharedResource> sharedResourceLocalizer)
        {
            _sharedResourceLocalizer = sharedResourceLocalizer;
        }
        [HttpGet ("GetValue")]
        public IActionResult Index()
        {
            var uno = _sharedResourceLocalizer.GetString("Hello").Value ?? "";
            var dos = _sharedResourceLocalizer["Hello"];
            return Ok(dos);
        }
    }
}
