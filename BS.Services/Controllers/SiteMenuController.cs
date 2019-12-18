using System.Collections.Generic;
using System.Linq;
//using BS.App.Interfaces;
//using BS.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SiteMenuController : ControllerBase
    {
        //private readonly ISiteMenuApp _siteMenuApp;

        //public SiteMenuController(ISiteMenuApp siteMenuApp)
        //{
        //    _siteMenuApp = siteMenuApp;
        //}

        [HttpGet]
        public JsonResult GetMenu()
        {
            //using (BlackSipContext db = new BlackSipContext())
            //{
            //    var lst = (from d in db.SiteMenu
            //        select d).ToList();

            //    return new JsonResult(lst);
            //}

            return null;
        }
    }
}