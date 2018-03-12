using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
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
    }
}