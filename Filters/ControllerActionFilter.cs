using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterTutorial.Filters
{
    public class ControllerActionFilter : IActionFilter
    {
        private readonly ILogger _logger;
        public ControllerActionFilter(ILogger<ControllerActionFilter> logger)
        {
            this._logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Controller Action Filter!(After)");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Controller Action Filter!(Before)");
        }
    }
}