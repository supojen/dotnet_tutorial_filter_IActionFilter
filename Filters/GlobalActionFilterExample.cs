using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterTutorial.Filters
{
    public class GlobalActionFilterExample : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}