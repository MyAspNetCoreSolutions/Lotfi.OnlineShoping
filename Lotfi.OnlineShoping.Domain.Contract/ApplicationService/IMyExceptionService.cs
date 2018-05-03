using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.ApplicationService
{
    public interface IMyExceptionService
    {
        void Add(MyException myException);
        void Update(MyException myException);
        IEnumerable<MyException> Get(MyException myException);
        void Delete(object id);
        void Delete(MyException myException);
    }
}
