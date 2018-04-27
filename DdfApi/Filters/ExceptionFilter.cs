using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DdfApi.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        /// <inheridoc/>
        public void OnException(ExceptionContext context)
        {
            context.Result = new ContentResult()
            {
            //    var contentResult = new ContentResult()
            //    {
            //        StatusCode = (int)System.Net.HttpStatusCode.InternalServerError,
            //        Content = _environment.IsDevelopment
            //"Ups :  ("
            //    }
            }
        }
    }
}
