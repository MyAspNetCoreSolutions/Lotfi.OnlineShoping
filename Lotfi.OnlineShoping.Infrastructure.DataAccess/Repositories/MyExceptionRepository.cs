using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lotfi.OnlineShoping.Domain.Contract.Repositories;

namespace Lotfi.OnlineShoping.Infrastructure.DataAccess
{
    public class MyExceptionRepository : IMyExceptionRepository
    {
        #region Fields
        private MyShopContext _context;
        #endregion

        #region Constractor
        public MyExceptionRepository(MyShopContext context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public void Delete(MyException entity)
        {
            _context.MyExceptions.Remove(entity);
        }

        public MyException Find(int id)
        {
            return _context.MyExceptions.Find(id);
        }

        public IEnumerable<MyException> GetAll()
        {
            return _context.MyExceptions.ToList();
        }

        public void Insert(MyException entity)
        {
            _context.MyExceptions.Add(entity);
        }

        public void Update(MyException entity)
        {
            _context.MyExceptions.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
