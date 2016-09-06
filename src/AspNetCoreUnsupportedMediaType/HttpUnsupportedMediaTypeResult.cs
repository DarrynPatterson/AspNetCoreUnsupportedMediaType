using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreUnsupportedMediaType
{
    public class HttpUnsupportedMediaTypeResult : ObjectResult
    {
        public HttpUnsupportedMediaTypeResult()
            : base(UnsupportedMediaTypeModel.Create())
        {
            StatusCode = 415;
        }
    }
}