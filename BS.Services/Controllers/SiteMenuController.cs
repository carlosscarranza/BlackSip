using BS.App.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SiteMenuController : ControllerBase
    {
        private readonly ISiteMenuApp _siteMenuApp;

        public SiteMenuController(ISiteMenuApp siteMenuApp)
        {
            _siteMenuApp = siteMenuApp;
        }

        [HttpGet]
        public JsonResult GetMenu()
        {
            return new JsonResult(_siteMenuApp.GetMenu());
        }
    }
}