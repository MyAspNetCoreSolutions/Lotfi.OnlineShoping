using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using Lotfi.OnlineShoping.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotfi.OnlineShoping.Filters
{
    public class LogVisitorsFilter : IActionFilter
    {
        private readonly IVistorLogService _vistorLog;
        public LogVisitorsFilter(IVistorLogService vistorLog)
        {
            _vistorLog = vistorLog;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            




            CookieOptions cookieOption = new CookieOptions()
            {
                Expires=DateTime.Now.AddDays(1)
            };
            string ipAddress = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            string v;
            if (!context.HttpContext.Request.Cookies.TryGetValue(ipAddress,out v))
            {
                context.HttpContext.Response.Cookies.Append(ipAddress,context.HttpContext.Request.Path, cookieOption);

                _vistorLog.Add(new VisitorLog()
                {
                    Controller = context.ActionDescriptor.RouteValues["Controller"],
                    Action = context.ActionDescriptor.RouteValues["Action"],
                    Url = context.HttpContext.Request.Path,
                    CookieId =ipAddress
                });
            }
            
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
        }

    }
}
