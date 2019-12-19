using System;
using System.Collections.Generic;
using BS.App.Interfaces;
using BS.Domain;
using BS.Utilities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SiteMenuController : ControllerBase
    {
        private readonly ISiteMenuApp _siteMenuApp;
        private readonly IVisitanteApp _visitanteApp;
        private readonly int _counter;

        public SiteMenuController(ISiteMenuApp siteMenuApp, IVisitanteApp visitanteApp)
        {
            _siteMenuApp = siteMenuApp;
            _visitanteApp = visitanteApp;
            if (_counter != 0) return;
            ProcessVisitors();
            _counter++;
        }

        [HttpGet]
        public JsonResult GetMenu()
        {
            return new JsonResult(_siteMenuApp.GetMenu());
        }

        //Activo el proceso para validar a los visitantes
        public void ProcessVisitors()
        {
            DateTime localDateTime = DateTime.Now;
            MyScheduler.IntervalInMinutes(localDateTime.Hour, localDateTime.Minute + 2, 1,
                Procesar);
        }

        public void Procesar()
        {
            _visitanteApp.ProcessVisitors();
        }
    }
}