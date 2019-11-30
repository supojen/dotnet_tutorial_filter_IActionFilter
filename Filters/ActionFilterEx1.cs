using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterTutorial.Filters
{
    public class ActionFilterEx1 : IActionFilter
    {
        private readonly ILogger _logger;
        public ActionFilterEx1(ILogger<ActionFilterEx1> logger)
        {
            this._logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action Filter Number 1(After)!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action Filter Number 1(Before)!");
        }
    }
}