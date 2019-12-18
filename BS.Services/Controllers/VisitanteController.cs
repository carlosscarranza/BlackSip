using System;
using System.Collections.Generic;
using BS.App.Interfaces;
using BS.Domain;
using BS.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitanteController : ControllerBase
    {
        private readonly IVisitanteApp _visitanteApp;

        public VisitanteController(IVisitanteApp visitanteApp)
        {
            _visitanteApp = visitanteApp;
        }

        //Agrego un visitante
        [HttpPost]
        public int CreateVisitante(Visitante visitante)
        {
            return _visitanteApp.Create(visitante);
        }

        //Obtengo los visitante ya procesados
        [HttpGet]
        public List<Visitante> GetVisitantesProcesados()
        {
            return _visitanteApp.GetVisitantesProcesados();
        }

        //Activo el proceso para validar a los visitantes
        [HttpPost]
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