using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Lotfi.OnlineShoping.Controllers
{
    public class HomeController : Controller
    {
        ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View(_customerService.Get());
        }
        [TypeFilter(typeof(MyExceptionFilterAttribute))]
        public IActionResult Index1()
        {
            throw new Exception()
            {
                HelpLink = "this is HelpLink",
                Source = "this is source"
            };
            return View(_customerService.Get());
        }
    }
}