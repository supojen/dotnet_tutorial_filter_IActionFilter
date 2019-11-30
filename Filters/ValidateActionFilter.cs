using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Linq;
using FilterTutorial.Model;


namespace FilterTutorial.Filters
{
    public class ValidateActionFilter : IActionFilter
    {
        private readonly ILogger _logger;
        public ValidateActionFilter(ILogger<ValidateActionFilter> logger)
        {
            this._logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Fuck");
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is Movie);
            if(param.Value != null)
            {
                _logger.LogInformation(param.Value.ToString());
            }

        }
    }
}