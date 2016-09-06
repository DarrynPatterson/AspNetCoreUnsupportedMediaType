using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AspNetCoreUnsupportedMediaType
{
    public class ValidateUnsupportedMediaTypeFilterAttribute : ActionFilterAttribute
    {
        private const string ContentType = "application/json";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Do not proceed if this is an invalid request object
            if (context.HttpContext == null || context.HttpContext.Request == null)
            {
                return;
            }

            var request = context.HttpContext.Request;

            // Is this a POST or PUT request?
            var requestMethod = request.Method.ToUpper();
            if (requestMethod == WebRequestMethods.Http.Post || requestMethod == WebRequestMethods.Http.Put)
            {
                // Validate the "Content-Type" header
                if (request.ContentType != ContentType)
                {
                    // "Unsupported Media Type" HTTP result
                    context.Result = new HttpUnsupportedMediaTypeResult();

                    return;
                }
            }
        }
    }
}