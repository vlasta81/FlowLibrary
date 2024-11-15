#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions').[Responsibility&lt;TRequest,TResponse&gt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')

## Responsibility<TRequest,TResponse>.HandleAsync(TRequest) Method

Handles the request asynchronously. If the current handler cannot handle the request,  
it delegates to the next handler in the chain.

```csharp
public virtual System.Threading.Tasks.Task<TResponse?> HandleAsync(TRequest request);
```
#### Parameters

<a name='FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.HandleAsync(TRequest).request'></a>

`request` [TRequest](Responsibility_TRequest,TResponse_.md#FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TRequest 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.TRequest')

The request to handle.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Responsibility_TRequest,TResponse_.md#FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TResponse 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response.