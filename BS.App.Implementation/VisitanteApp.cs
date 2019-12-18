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
    }
}