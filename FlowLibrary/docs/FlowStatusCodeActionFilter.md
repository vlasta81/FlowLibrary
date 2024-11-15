#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Filters](FlowLibrary.Filters.md 'FlowLibrary.Filters')

## FlowStatusCodeActionFilter Class

An action filter that sets the status code of the response based on the [StatusCode](Response.StatusCode.md 'FlowLibrary.Common.Response.StatusCode') property.

```csharp
public class FlowStatusCodeActionFilter :
Microsoft.AspNetCore.Mvc.Filters.IActionFilter,
Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FlowStatusCodeActionFilter

Implements [Microsoft.AspNetCore.Mvc.Filters.IActionFilter](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Filters.IActionFilter 'Microsoft.AspNetCore.Mvc.Filters.IActionFilter'), [Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata 'Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata')

| Methods | |
| :--- | :--- |
| [OnActionExecuted(ActionExecutedContext)](FlowStatusCodeActionFilter.OnActionExecuted.OzV/cRGQSvn8t2SmwPv8ZQ.md 'FlowLibrary.Filters.FlowStatusCodeActionFilter.OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext)') | Called after the action method is executed. |
| [OnActionExecuting(ActionExecutingContext)](FlowStatusCodeActionFilter.OnActionExecuting./zfzbob1egiGVz6/PMnSzA.md 'FlowLibrary.Filters.FlowStatusCodeActionFilter.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)') | Called before the action method is executed. |
