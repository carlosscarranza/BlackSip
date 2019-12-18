using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BS.App.Interfaces;
using BS.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    public class VisitanteController : Controller
    {
        private readonly IVisitanteApp _visitanteApp;

        public VisitanteController(IVisitanteApp visitanteApp)
        {
            _visitanteApp = visitanteApp;
        }

        public int CreateVisitante(Visitante visitante)
        {
            return _visitanteApp.Create(visitante);
        }
    }
}