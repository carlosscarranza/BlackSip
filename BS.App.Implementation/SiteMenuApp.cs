using BS.App.Interfaces;
using BS.Domain;
using BS.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace BS.App.Implementation
{
    public class SiteMenuApp : ISiteMenuApp
    {
        public IEnumerable<SiteMenu> GetMenu()
        {
            return UnitOfWork.I.SiteMenuRepository.GetAll().ToList();
        }
    }
}