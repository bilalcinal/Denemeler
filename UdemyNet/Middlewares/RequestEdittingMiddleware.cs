using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;

namespace UdemyNet.Middlewares
{
    public class RequestEdittingMiddleware
    {
       private RequestDelegate _requestDelegate;

       public RequestEdittingMiddleware(RequestDelegate requestDelegate)
       {
        _requestDelegate = requestDelegate;
       }

       public async Task Invoke(HttpContext context)
       {
        if (context.Request.Path.ToString()== "/bilal")
             await context.Response.WriteAsync("hoşgeldin bilal");
        else
             await _requestDelegate.Invoke(context);
       }
    }
}    