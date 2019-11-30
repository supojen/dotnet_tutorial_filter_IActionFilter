using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterTutorial.Filters
{
    public class ActionFilterEx2 : IActionFilter
    {
        private readonly ILogger _logger;
        public ActionFilterEx2(ILogger<ActionFilterEx2> logger)
        {
            this._logger = logger;
        }

        // After Action Method Executed
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogWarning("Action Filter Number 2(After)!");
        }

        // Before Action Method Executedd
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogWarning("Action Filter Number 2(Before)!");
        }
    }
}