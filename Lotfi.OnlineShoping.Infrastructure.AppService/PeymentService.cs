using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class PeymentService : IPeymentService
    {
        IPeymentRepository _peymentRepository;
        public PeymentService(IPeymentRepository peymentRepository)
        {
            this._peymentRepository = peymentRepository;
        }
        public void Add(Peyment peyment)
        {
            _peymentRepository.Insert(peyment);
        }
    }
}
