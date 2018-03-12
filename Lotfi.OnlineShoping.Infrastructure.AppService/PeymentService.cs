using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class PeymentService : IPeymentService
    {
        #region Fileds
        IPeymentRepository _peymentRepository;
        #endregion

        #region Constractor
        public PeymentService(IPeymentRepository peymentRepository)
        {
            this._peymentRepository = peymentRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(Peyment peyment)
        {
            _peymentRepository.Insert(peyment);
        }
        #endregion

    }
}
