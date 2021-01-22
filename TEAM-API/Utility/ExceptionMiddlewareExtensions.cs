using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TEAM_API.Utility
{
    public class ExceptionMiddlewareExtensions
    {
        private readonly RequestDelegate next;

        public ExceptionMiddlewareExtensions(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private static Task HandleException(HttpContext context, Exception ex)
        {
            HttpStatusCode code = HttpStatusCode.InternalServerError; // 500 if unexpected

            // Specify different custom exceptions here
            //if (ex is CustomException) code = HttpStatusCode.BadRequest;

            string result = JsonConvert.SerializeObject(new { error = ex.Message });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }
    }
}
