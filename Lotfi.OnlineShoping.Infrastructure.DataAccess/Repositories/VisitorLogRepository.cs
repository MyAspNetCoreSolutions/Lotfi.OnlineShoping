using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lotfi.OnlineShoping.Domain.Contract.Repositories;

namespace Lotfi.OnlineShoping.Infrastructure.DataAccess
{
    public class VisitorLogRepository : IVisitorLogRepository
    {
        #region Fields
        private MyShopContext _context;
        #endregion

        #region Constractor
        public VisitorLogRepository(MyShopContext context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public void Delete(VisitorLog entity)
        {
            _context.VisitorLogs.Remove(entity);
        }

        public VisitorLog Find(int id)
        {
            return _context.VisitorLogs.Find(id);
        }

        public IEnumerable<VisitorLog> GetAll()
        {
            return _context.VisitorLogs.ToList();
        }

        public void Insert(VisitorLog entity)
        {
            _context.VisitorLogs.Add(entity);
            this.Save();
        }

        public void Update(VisitorLog entity)
        {
            _context.VisitorLogs.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
