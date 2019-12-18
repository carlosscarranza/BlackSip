using System.Collections.Generic;
using BS.Domain;

namespace BS.App.Interfaces
{
    public interface IVisitanteApp
    {
        int Create(Visitante visitante);

        List<Visitante> GetVisitantesProcesados();


    }
}