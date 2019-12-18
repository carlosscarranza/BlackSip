using BS.Domain;
using System;

namespace BS.Infrastructure
{
    public sealed class UnitOfWork
    {
        public UnitOfWork()
        {
            this._context = new BlackSipContext();
        }
        private readonly BlackSipContext _context;

        public static UnitOfWork I { get; } = new UnitOfWork();

        #region Visitante
        private GenericRepository<Visitante> _visitanteRepository;
        public GenericRepository<Visitante> VisitanteRepository =>
            this._visitanteRepository ?? (this._visitanteRepository = new GenericRepository<Visitante>(this._context));
        #endregion

        #region SiteMenu
        private GenericRepository<SiteMenu> _siteMenuRepository;
        public GenericRepository<SiteMenu> SiteMenuRepository =>
            this._siteMenuRepository ?? (this._siteMenuRepository = new GenericRepository<SiteMenu>(this._context));
        #endregion

        public int SaveChanges()
        {
            return this._context.SaveChanges();
        }
    }
}
