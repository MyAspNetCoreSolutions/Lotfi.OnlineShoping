using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotfi.OnlineShoping.Filters
{
    public class MyExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly IMyExceptionRepository _exceptionRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public MyExceptionFilterAttribute(IMyExceptionRepository repository, IHostingEnvironment hostingEnvironment,
        IModelMetadataProvider modelMetadataProvider)
        {
            _exceptionRepository = repository;
            _hostingEnvironment = hostingEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            MyException myException = new MyException() {
                ControllerName = context.ActionDescriptor.RouteValues["Controller"],
                Message = context.Exception.Message,
                ActionName = context.ActionDescriptor.RouteValues["Action"],
                CreatedTime=DateTime.Now,
                UpdatedTime =DateTime.Now,
                Date=DateTime.Now,
                InnerMessage="",
                IsReaded =false
            };

            _exceptionRepository.Insert(myException);
            _exceptionRepository.Save();
            

            var result = new ViewResult { ViewName = "CustomError" };
            result.ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState);
            result.ViewData.Add("Exception", context.Exception);
            result.ViewData.Model = myException;
            // TODO: Pass additional detailed data via ViewData
            context.Result = result;
        }
    }
}
