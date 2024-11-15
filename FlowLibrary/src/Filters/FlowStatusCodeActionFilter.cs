using FlowLibrary.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FlowLibrary.Filters
{
    /// <summary>
    /// An action filter that sets the status code of the response based on the <see cref="Response.StatusCode"/> property.
    /// </summary>
    public class FlowStatusCodeActionFilter : IActionFilter
    {
        /// <summary>
        /// Called before the action method is executed.
        /// </summary>
        /// <param name="context">The context for the action.</param>
        public void OnActionExecuting(ActionExecutingContext context) { }

        /// <summary>
        /// Called after the action method is executed.
        /// </summary>
        /// <param name="context">The context for the action.</param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult && objectResult.Value is Response response)
            {
                objectResult.StatusCode = response.StatusCode;
            }
        }
    }
}
