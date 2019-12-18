using System.Collections.Generic;
using BS.Domain;

namespace BS.App.Interfaces
{
    public interface ISiteMenuApp
    {
        IEnumerable<SiteMenu> GetMenu();
    }
}