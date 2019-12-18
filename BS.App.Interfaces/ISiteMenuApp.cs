using BS.Domain;
using System.Collections.Generic;

namespace BS.App.Interfaces
{
    public interface ISiteMenuApp
    {
        IEnumerable<SiteMenu> GetMenu();
    }
}