using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using Lotfi.OnlineShoping.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class VisitorLogService : IVistorLogService
    {
        #region Fileds
        private IVisitorLogRepository _VisitorLogRepository;
        #endregion

        #region Constractor
        public VisitorLogService(IVisitorLogRepository VisitorLogRepository)
        {
            this._VisitorLogRepository = VisitorLogRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(VisitorLog VisitorLog)
        {
            _VisitorLogRepository.Insert(VisitorLog);
        }
        #endregion
    }
}
