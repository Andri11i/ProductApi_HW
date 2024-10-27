using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi_HW
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var response = new
            {
                Message = "An unexpected error occurred.",
                Error = context.Exception.Message
            };
            context.Result = new JsonResult(response) { StatusCode = 500 };
            context.ExceptionHandled = true;
        }
    }
}
