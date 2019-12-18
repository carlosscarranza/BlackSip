using System.Collections.Generic;
using System.Linq;
using BS.App.Interfaces;
using BS.Domain;
using BS.Infrastructure;


namespace BS.App.Implementation
{
    public class VisitanteApp : IVisitanteApp
    {
        public int Create(Visitante visitante)
        {
            UnitOfWork.I.VisitanteRepository.Create(visitante);
            return UnitOfWork.I.SaveChanges();
        }

        public List<Visitante> GetVisitantesProcesados()
        {
            return UnitOfWork.I.VisitanteRepository.Filter(x => x.Procesado == true).ToList();
        }

        public void ProcessVisitors()
        {
            UnitOfWork.I.VisitanteRepository.SqlQuery("EXECUTE dbo.SPGETVISITANTESPROCESADOS");
        }
    }
}