#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IResponsibility&lt;TRequest,TResponse&gt;](IResponsibility_TRequest,TResponse_.md 'FlowLibrary.Contracts.IResponsibility<TRequest,TResponse>')

## IResponsibility<TRequest,TResponse>.HandleAsync(TRequest) Method

Handles the specified request asynchronously and returns a response.

```csharp
System.Threading.Tasks.Task<TResponse?> HandleAsync(TRequest request);
```
#### Parameters

<a name='FlowLibrary.Contracts.IResponsibility_TRequest,TResponse_.HandleAsync(TRequest).request'></a>

`request` [TRequest](IResponsibility_TRequest,TResponse_.md#FlowLibrary.Contracts.IResponsibility_TRequest,TResponse_.TRequest 'FlowLibrary.Contracts.IResponsibility<TRequest,TResponse>.TRequest')

The request to handle.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](IResponsibility_TRequest,TResponse_.md#FlowLibrary.Contracts.IResponsibility_TRequest,TResponse_.TResponse 'FlowLibrary.Contracts.IResponsibility<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response.