#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[ICommand&lt;TRequest,TResponse&gt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')

## ICommand<TRequest,TResponse>.ExecuteAsync(TRequest) Method

Executes the command asynchronously with the specified request.

```csharp
System.Threading.Tasks.Task<TResponse> ExecuteAsync(TRequest request);
```
#### Parameters

<a name='FlowLibrary.Contracts.ICommand_TRequest,TResponse_.ExecuteAsync(TRequest).request'></a>

`request` [TRequest](ICommand_TRequest,TResponse_.md#FlowLibrary.Contracts.ICommand_TRequest,TResponse_.TRequest 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>.TRequest')

The request parameter.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](ICommand_TRequest,TResponse_.md#FlowLibrary.Contracts.ICommand_TRequest,TResponse_.TResponse 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response.