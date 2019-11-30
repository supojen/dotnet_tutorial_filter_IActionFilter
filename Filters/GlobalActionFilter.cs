using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterTutorial.Filters
{
    public class GlobalActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("GlobalFilter","GlobalFilter");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}