using System;
using System.Collections.Generic;
using BS.Domain;

namespace BS.Infrastructure
{
    public sealed class UnitOfWork
    {
        public UnitOfWork()
        {
            this._context = new BlackSipEntities();
        }
        private readonly BlackSipEntities _context;

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
            int response = this._context.SaveChanges();
            _context.Database.Connection.Close();
            return response;
        }
    }
}
