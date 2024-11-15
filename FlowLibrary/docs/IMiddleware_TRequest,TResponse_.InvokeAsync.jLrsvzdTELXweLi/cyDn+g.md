#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IMiddleware&lt;TRequest,TResponse&gt;](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')

## IMiddleware<TRequest,TResponse>.InvokeAsync(TRequest, Func<TRequest,Task<TResponse>>) Method

Invokes the middleware with the specified request and the next middleware in the pipeline.

```csharp
System.Threading.Tasks.Task<TResponse?> InvokeAsync(TRequest request, System.Func<TRequest,System.Threading.Tasks.Task<TResponse?>> next);
```
#### Parameters

<a name='FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.InvokeAsync(TRequest,System.Func_TRequest,System.Threading.Tasks.Task_TResponse__).request'></a>

`request` [TRequest](IMiddleware_TRequest,TResponse_.md#FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TRequest 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>.TRequest')

The request object.

<a name='FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.InvokeAsync(TRequest,System.Func_TRequest,System.Threading.Tasks.Task_TResponse__).next'></a>

`next` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TRequest](IMiddleware_TRequest,TResponse_.md#FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TRequest 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>.TRequest')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](IMiddleware_TRequest,TResponse_.md#FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TResponse 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The next middleware function in the pipeline.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](IMiddleware_TRequest,TResponse_.md#FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TResponse 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.